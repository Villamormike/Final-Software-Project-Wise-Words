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
    public partial class Learn : Form
    {
        private readonly DatabaseConnection _conn;//sqlite connection handler
        private List<Flashcards> flashcards = new List<Flashcards>(); // list store flashcards
        private int currentIndex = 0;


        public Learn()
        {
            InitializeComponent();
            _conn = new DatabaseConnection();
            this.Load += Learn_Load;
            LoadFlashcards();
            DisplayFlashcard();

        }
        private void Learn_Load(object sender, EventArgs e)
        {
            LoadFlashcards();
            DisplayFlashcard();
        }

        private void LoadFlashcards()
        {
            flashcards.Clear(); // Ensure no duplicates

            string selectedGrade = NormalizeGrade(Difficulty_Selection.SelectedGrade);
            string selectedSubject = NormalizeSubject(Difficulty_Selection.SelectedSubject);
            string selectedDifficulty = NormalizeDifficulty(Difficulty_Selection.SelectedDifficulty);

            // Verify matching criteria in the database
            string checkQuery = @"SELECT COUNT(*) 
                                  FROM flashcard_view 
                                  WHERE grade_name = @Grade 
                                  AND subject_name = @Subject 
                                  AND level_name = @Difficulty";

            using (var connection = _conn.GetConnection())
            {
                using (var checkCmd = new SqliteCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@Grade", selectedGrade);
                    checkCmd.Parameters.AddWithValue("@Subject", selectedSubject);
                    checkCmd.Parameters.AddWithValue("@Difficulty", selectedDifficulty);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show($"No flashcards found for:\nGrade: {selectedGrade}\nSubject: {selectedSubject}\nDifficulty: {selectedDifficulty}", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Load flashcards that match the criteria
                string query = @"SELECT question, answer, mca, type, image 
                                 FROM flashcard_view
                                 WHERE grade_name = @Grade
                                 AND subject_name = @Subject
                                 AND level_name = @Difficulty";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Grade", selectedGrade);
                    command.Parameters.AddWithValue("@Subject", selectedSubject);
                    command.Parameters.AddWithValue("@Difficulty", selectedDifficulty);

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string question = reader["question"].ToString();
                                string answer = reader["answer"].ToString();
                                string type = reader["type"].ToString();
                                string mca = reader["mca"] == DBNull.Value ? "" : reader["mca"].ToString();
                                byte[] imageBytes = reader["image"] as byte[];

                                flashcards.Add(new Flashcards(question, mca, answer, type, imageBytes));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading flashcards: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            DisplayFlashcard();
        }


        private void DisplayFlashcard()
        {
            if (flashcards.Count > 0 && currentIndex >= 0 && currentIndex < flashcards.Count)
            {
                var flashcard = flashcards[currentIndex];

                queslabel.Text = flashcard.Question;

                if (flashcard.Type == "PIX")
                {
                    if (flashcard.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(flashcard.Image))
                        {
                            picture.Image = Image.FromStream(ms);
                            picture.Visible = true;
                        }
                    }
                    else
                    {
                        picture.Visible = false;
                    }
                    anslabel.Text = "Tap to reveal answer"; // <-- always show this hint
                }
                else
                {
                    picture.Visible = false;

                    if (flashcard.Choices.Length > 0)
                    {
                        anslabel.Text = string.Join("\n", flashcard.Choices);
                    }
                    else
                    {
                        anslabel.Text = "Tap to reveal answer"; // <-- same hint for others too
                    }
                }
            }
            else
            {
                queslabel.Text = "No flashcards available.";
                anslabel.Text = "";
                picture.Visible = false;
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < flashcards.Count - 1)
            {
                currentIndex++;
                DisplayFlashcard();
            }
        }

        private void anslabel_Click(object sender, EventArgs e)
        {
            anslabel.Text = flashcards[currentIndex].Answer;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        //this for in case mispelled difficulties, gradelevel, and subject ex. like kinder instead of Kindergarten
        private string NormalizeGrade(string grade)
        {
            return grade switch
            {
                "Kinder" => "Kindergarten", // Adjust if you're using "Kinder"
                _ => grade
            };
        }

        private string NormalizeSubject(string subject)
        {
            return subject; // You can add more cases later
        }

        private string NormalizeDifficulty(string difficulty)
        {
            return difficulty; // Same here, if needed
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
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
    }
}
