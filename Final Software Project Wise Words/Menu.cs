using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.Sqlite;

namespace Final_Software_Project_Wise_Words
{
    public partial class Menu : Form
    {

        private bool resizing = false;
        private Point lastMousePosition;
        private int resizeMargin = 10;
        private int edge = 0;
        public Menu()
        {
            InitializeComponent();
            CheckDifficulty();
            this.MouseDown += Menu_MouseDown;
            this.MouseMove += Menu_MouseMove;
            this.MouseUp += Menu_MouseUp;

            UpdateAccessControls();
            if (User.LoggedInUser != null)
            {
                difselectlbl.Text = $"Welcome, {User.LoggedInUser.Username}";
            }
            else
            {
                difselectlbl.Text = "Welcome, Guest";
            }

        }
        private void UpdateAccessControls()
        {
            learnbtn.Enabled = Difficulty_Selection.IsSelectionComplete();
            quizbtn.Enabled = Difficulty_Selection.IsSelectionComplete();

           
            if (User.LoggedInUser != null)
            {
                difselectlbl.Text = Difficulty_Selection.IsSelectionComplete()
                    ? $"Current: {Difficulty_Selection.SelectedGrade} ({Difficulty_Selection.SelectedDifficulty}) - {User.LoggedInUser.Username}"
                    : $"No difficulty selected - {User.LoggedInUser.Username}";
            }
            else
            {
                difselectlbl.Text = Difficulty_Selection.IsSelectionComplete()
                    ? $"Current: {Difficulty_Selection.SelectedGrade} ({Difficulty_Selection.SelectedDifficulty})"
                    : "No difficulty selected";
            }
        }
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (edge != 0)
            {
                resizing = true;
                lastMousePosition = e.Location;
            }
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                if ((edge & 1) != 0)
                {
                    this.Left += deltaX;
                    this.Width -= deltaX;
                }
                if ((edge & 2) != 0)
                {
                    this.Width += deltaX;
                }
                if ((edge & 4) != 0)
                {
                    this.Top += deltaY;
                    this.Height -= deltaY;
                }
                if ((edge & 8) != 0)
                {
                    this.Height += deltaY;
                }

                lastMousePosition = e.Location;
            }
            else
            {
                edge = 0;
                if (e.X <= resizeMargin) edge |= 1;
                if (e.X >= this.Width - resizeMargin) edge |= 2;
                if (e.Y <= resizeMargin) edge |= 4;
                if (e.Y >= this.Height - resizeMargin) edge |= 8;
                if (edge == 1 || edge == 2) this.Cursor = Cursors.SizeWE;
                else if (edge == 4 || edge == 8) this.Cursor = Cursors.SizeNS;
                else if (edge == 5 || edge == 10) this.Cursor = Cursors.SizeNWSE;
                else if (edge == 6 || edge == 9) this.Cursor = Cursors.SizeNESW;
                else this.Cursor = Cursors.Default;
            }
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
            this.Cursor = Cursors.Default;
        }

        private void CheckDifficulty()
        {
            learnbtn.Enabled = Difficulty_Selection.IsSelectionComplete();
            quizbtn.Enabled = Difficulty_Selection.IsSelectionComplete();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            if (User.LoggedInUser != null)
            {
                var selection = UserSelection.LoadUserSelection(User.LoggedInUser.UserID);
                if (selection.HasValue)
                {
                    Difficulty_Selection.SelectedGrade = selection.Value.grade;
                    Difficulty_Selection.SelectedSubject = selection.Value.subject;
                    Difficulty_Selection.SelectedDifficulty = selection.Value.difficulty;
                }
            }

            // Now update the button enable/disable state based on the loaded difficulty
            CheckDifficulty();
            CheckDifficulty();

        }

        private void learnbtn_Click(object sender, EventArgs e)
        {
            if (!Difficulty_Selection.IsSelectionComplete())
            {
                MessageBox.Show("Please select a difficulty first!", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RecordHistory("Learn Mode", "User started Learn Mode");
            Learn learnForm = new Learn();
            learnForm.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
            loginForm.FormClosed += (s, args) => this.Close();
        }

        private void diffbtn_Click(object sender, EventArgs e)
        {

            using (Difficulty difficultyForm = new Difficulty())
            {
                if (difficultyForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateAccessControls();
                }
            }
        }

        private void quizbtn_Click(object sender, EventArgs e)
        {
            if (!Difficulty_Selection.IsSelectionComplete())
            {
                MessageBox.Show("Please select a difficulty first!", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RecordHistory("Quiz Mode", "User started Quiz Mode");
            Quiz quizForm = new Quiz();
            quizForm.Show();
            this.Hide();
        }
        bool sideabarExpand = true;
        private void sidebartransition_Tick(object sender, EventArgs e)//this for side bar
        {
            if (sideabarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 51)
                {
                    sideabarExpand = false;
                    sidebartransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 216)
                {
                    sideabarExpand = true;
                    sidebartransition.Stop();
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        private void randombtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Randomize the difficulty, subject, and grade
                Difficulty_Selection.Randomize();

                // Update UI with the random selection
                UpdateAccessControls();
                difselectlbl.Text = $"Random: {Difficulty_Selection.SelectedGrade} " +
                                    $"{Difficulty_Selection.SelectedSubject} " +
                                    $"({Difficulty_Selection.SelectedDifficulty})";

                // Visual feedback
                randombtn.BackColor = Color.LightGreen;
                Task.Delay(300).ContinueWith(t =>
                {
                    this.Invoke((MethodInvoker)(() => randombtn.BackColor = SystemColors.Control));
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error randomizing: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void leaderbtn_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboardForm = new Leaderboard();

            // Show the LeaderboardForm
            leaderboardForm.Show();

        }

        private void historybtn_Click(object sender, EventArgs e)
        {
            History historyForm = new History();

            // Show the LeaderboardForm
            historyForm.Show();
        }
        private void RecordHistory(string activity, string details)
        {
            try
            {
                using (var connection = new Database.DatabaseConnection().GetConnection())
                {
                    connection.Open();
                    string insertQuery = @"
                        INSERT INTO user_history (user_id, activity, details, activity_date)
                        VALUES (@userId, @activity, @details, CURRENT_TIMESTAMP)";

                    using (var command = new SqliteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userId", User.LoggedInUser.UserID);
                        command.Parameters.AddWithValue("@activity", activity);
                        command.Parameters.AddWithValue("@details", details);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording history: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


