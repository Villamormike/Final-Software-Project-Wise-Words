using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static Final_Software_Project_Wise_Words.Database;

namespace Final_Software_Project_Wise_Words
{
    public partial class Quiz : Form
    {

        private readonly DatabaseConnection _conn;
        private List<string> userAnswers = new List<string>();
        private List<Flashcards> flashcards = new List<Flashcards>();
        private int currentIndex = 0;
        private int score = 0;

        

        public Quiz()
        {
            InitializeComponent();
            _conn = new DatabaseConnection();
            LoadFlashcards();
            InitializeUserAnswers();
            DisplayFlashcard();
        }
        private void InitializeUserAnswers()
        {
            userAnswers.Clear();
            for (int i = 0; i < flashcards.Count; i++)
            {
                userAnswers.Add("");
            }
        }
        private void SaveUserAnswer()
        {
            var currentFlashcard = flashcards[currentIndex];

            if (currentFlashcard.Type == "ID" || currentFlashcard.Type == "FITB" || currentFlashcard.Type == "PS" || currentFlashcard.Type == "PIX")
            {
                userAnswers[currentIndex] = anstbx.Text.Trim();
            }
            else if (currentFlashcard.Type == "MCQ")
            {
                RadioButton selectedOption = choicebox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (selectedOption != null)
                {
                    userAnswers[currentIndex] = selectedOption.Text.Trim();
                }
            }

        }

        private void LoadFlashcards()
        {
            flashcards.Clear();
            string query = @"SELECT question, answer, mca, type, image 
                     FROM flashcard_view 
                     WHERE grade_name = @Grade 
                     AND subject_name = @Subject 
                     AND level_name = @Difficulty";

            using (SqliteConnection connection = _conn.GetConnection())
            {
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Grade", Difficulty_Selection.SelectedGrade);
                    command.Parameters.AddWithValue("@Subject", Difficulty_Selection.SelectedSubject);
                    command.Parameters.AddWithValue("@Difficulty", Difficulty_Selection.SelectedDifficulty);

                    try
                    {
                        SqliteDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string question = reader["question"].ToString();
                            string answer = reader["answer"].ToString();
                            string type = reader["type"].ToString();
                            string mca = reader["mca"] == DBNull.Value ? "" : reader["mca"].ToString();
                            byte[] image = reader["image"] == DBNull.Value ? null : (byte[])reader["image"];

                            flashcards.Add(new Flashcards(question, mca, answer, type, image));
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading flashcards: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (flashcards.Count == 0)
            {
                MessageBox.Show("No flashcards found for the selected criteria.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Randomize the order of the questions
            Random rng = new Random();
            flashcards = flashcards.OrderBy(q => rng.Next()).ToList();
        }
        

        private void DisplayFlashcard()
        {
            if (currentIndex >= 0 && currentIndex < flashcards.Count)
            {
                var currentFlashcard = flashcards[currentIndex];

                queslabel.Text = currentFlashcard.Question;

                // Image
                if (currentFlashcard.Image != null)
                {
                    using (var ms = new MemoryStream(currentFlashcard.Image))
                    {
                        picBox.Image = Image.FromStream(ms);
                    }
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picBox.Visible = true;
                }
                else
                {
                    picBox.Image = null;
                    picBox.Visible = false;
                }

                // Hide both answer areas first
                choicebox.Visible = false;
                anstbx.Visible = false;

                if (currentFlashcard.Type == "MCQ")
                {
                    choicebox.Visible = true;

                    choice1.Text = currentFlashcard.Choices.Length > 0 ? currentFlashcard.Choices[0] : "";
                    choice2.Text = currentFlashcard.Choices.Length > 1 ? currentFlashcard.Choices[1] : "";
                    choice3.Text = currentFlashcard.Choices.Length > 2 ? currentFlashcard.Choices[2] : "";
                    choice4.Text = currentFlashcard.Choices.Length > 3 ? currentFlashcard.Choices[3] : "";

                    // Reset radio buttons
                    foreach (Control control in choicebox.Controls)
                    {
                        if (control is RadioButton radio)
                        {
                            radio.Checked = false;
                        }
                    }

                    // Restore previous selected answer
                    if (!string.IsNullOrEmpty(userAnswers[currentIndex]))
                    {
                        foreach (Control control in choicebox.Controls)
                        {
                            if (control is RadioButton radio && radio.Text.Trim().ToLower() == userAnswers[currentIndex].Trim().ToLower())
                            {
                                radio.Checked = true;
                            }
                        }
                    }
                }
                else // ID, FITB, PS, PIX types
                {
                    anstbx.Visible = true;

                    if (!string.IsNullOrEmpty(userAnswers[currentIndex]))
                    {
                        anstbx.Text = userAnswers[currentIndex];
                    }
                    else
                    {
                        anstbx.Text = "";
                    }
                }

                // Disable Answer button if already answered
                ansbtn.Enabled = string.IsNullOrEmpty(userAnswers[currentIndex]);
            }
            else
            {
                MessageBox.Show("Invalid flashcard index!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void finishbtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Your final score: " + score + "/" + flashcards.Count, "Quiz Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                // Validate the parameters before inserting into the leaderboard
                if (User.LoggedInUser == null || string.IsNullOrEmpty(User.LoggedInUser.Username))
                {
                    MessageBox.Show("Username is not set. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(Difficulty_Selection.SelectedSubject) ||
                    string.IsNullOrEmpty(Difficulty_Selection.SelectedGrade) ||
                    string.IsNullOrEmpty(Difficulty_Selection.SelectedDifficulty))
                {
                    MessageBox.Show("Difficulty selection is incomplete. Please select grade, subject, and difficulty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save score to leaderboard_table
                string insertQuery = @"INSERT INTO leaderboard 
            (username, score, subject_name, level_name, grade_name, date_taken) 
            VALUES (@username, @score, @subject, @level, @grade, @date)";

                using (var conn = _conn.GetConnection())
                {
                    using (var cmd = new SqliteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", User.LoggedInUser.Username); // Use logged-in username
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.Parameters.AddWithValue("@subject", Difficulty_Selection.SelectedSubject);
                        cmd.Parameters.AddWithValue("@level", Difficulty_Selection.SelectedDifficulty);
                        cmd.Parameters.AddWithValue("@grade", Difficulty_Selection.SelectedGrade);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Score saved to leaderboard successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save score to leaderboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close(); // Close Quiz Form
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            SaveUserAnswer();
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayFlashcard();
            }
            else
            {
                MessageBox.Show("You are at the first question.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            SaveUserAnswer();
            if (currentIndex < flashcards.Count - 1)
            {
                currentIndex++;
                DisplayFlashcard();
            }
            else
            {
                MessageBox.Show("You have reached the last question.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ansbtn_Click(object sender, EventArgs e)
        {
            if (flashcards.Count == 0 || currentIndex < 0 || currentIndex >= flashcards.Count)
                return;

            var currentFlashcard = flashcards[currentIndex];

            if (!string.IsNullOrEmpty(userAnswers[currentIndex]))
            {
                MessageBox.Show("You have already answered this question!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userAnswer = "";

            if (new[] { "IDF", "FITB", "PS", "PIX" }.Contains(currentFlashcard.Type))
            {
                userAnswer = anstbx.Text.Trim().ToLower();

                // Split correct answers
                List<string> correctAnswers = currentFlashcard.Answer.Split(',')
                                                  .Select(a => a.Trim().ToLower())
                                                  .ToList();

                if (correctAnswers.Contains(userAnswer))
                {
                    score++;
                }
            }
            else if (currentFlashcard.Type == "MCQ")
            {
                RadioButton selectedOption = choicebox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (selectedOption != null)
                {
                    userAnswer = selectedOption.Text.Trim().ToLower();

                    List<string> correctAnswers = currentFlashcard.Answer.Split(',')
                                                  .Select(a => a.Trim().ToLower())
                                                  .ToList();

                    if (correctAnswers.Contains(userAnswer))
                    {
                        score++;
                    }
                }
                else
                {
                    MessageBox.Show("Please select an answer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Save answer
            userAnswers[currentIndex] = userAnswer;
            ansbtn.Enabled = false;

            // Move to next
            if (currentIndex < flashcards.Count - 1)
            {
                currentIndex++;
                DisplayFlashcard();
            }
            else
            {
                MessageBox.Show($"Quiz Finished!\nYour final score: {score}/{flashcards.Count}", "Quiz Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                finishbtn_Click(null, null);
            }
        }
    }
}
   
         
            
           
