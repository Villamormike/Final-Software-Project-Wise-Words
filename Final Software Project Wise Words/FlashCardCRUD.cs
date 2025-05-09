using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Final_Software_Project_Wise_Words
{
    public partial class FlashCardCRUD : Form
    {
        private readonly Database.DatabaseConnection _conn = new Database.DatabaseConnection();
        private byte[] imageData;

        public FlashCardCRUD()
        {
            InitializeComponent();
            LoadFlashcardDataToGrid();
            LoadSubjects();
            LoadDifficultyLevels();
            LoadGradeLevels();
            ConfigureDataGridView();
        }
        private void LoadSubjects()
        { //load subjects from the subject table into the cbx
            subjectcb.Items.Clear();
            using (var connection = _conn.GetConnection())
            {
                string query = "SELECT subject_name FROM subject";
                using (var cmd = new SqliteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjectcb.Items.Add(reader.GetString(0));
                    }
                }
            }
            if (subjectcb.Items.Count > 0) subjectcb.SelectedIndex = 0;
        }
        private void ConfigureDataGridView()
        {
            dgvflash.AutoGenerateColumns = true;
            dgvflash.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvflash.ReadOnly = true;
            dgvflash.AllowUserToAddRows = false;
            dgvflash.AllowUserToDeleteRows = false;
        }
        private void LoadDifficultyLevels()
        {
            difficultycb.Items.AddRange(new string[] { "Easy", "Moderate", "Hard" });
            difficultycb.SelectedIndex = 0;
        }
        private void LoadGradeLevels()
        {
            gardelevelcb.Items.AddRange(new string[] { "Kindergarten", "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6" });
            gardelevelcb.SelectedIndex = 0;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quesIDtbx.Text))
            {
                MessageBox.Show("Please select a flashcard to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(createquestbx.Text) ||
                string.IsNullOrWhiteSpace(quesanstbx.Text) ||
                string.IsNullOrWhiteSpace(typetbx.Text) ||
                subjectcb.SelectedIndex == -1 ||
                difficultycb.SelectedIndex == -1 ||
                gardelevelcb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all fields and select all ComboBoxes.");
                return;
            }

            try
            {
                using (var connection = _conn.GetConnection())
                {
                    connection.Open();

                    using (var pragma = new SqliteCommand("PRAGMA foreign_keys = ON;", connection))
                    {
                        pragma.ExecuteNonQuery();
                    }

                    // Check if an image is selected
                    byte[] imageData = null;
                    if (pictureBoxFlashcard.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxFlashcard.Image.Save(ms, pictureBoxFlashcard.Image.RawFormat);
                            imageData = ms.ToArray();  // Convert image to byte array
                        }
                    }

                    string query = @"UPDATE flashCard 
                             SET question = @question, 
                                 answer = @answer, 
                                 mca = @mca, 
                                 mc_choices = @mc_choices, 
                                 type = @type, 
                                 subject_id = @subjectID, 
                                 difficulty_id = @difficultyID, 
                                 grade_id = @gradeID, 
                                 image = @image 
                             WHERE card_id = @cardID";

                    using (var cmd = new SqliteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@question", createquestbx.Text);
                        cmd.Parameters.AddWithValue("@answer", quesanstbx.Text);
                        cmd.Parameters.AddWithValue("@mca", mcqchoicestbx.Text);

                        // Handle optional MCQ choices
                        if (string.IsNullOrWhiteSpace(mcqchoicestbx.Text))
                            cmd.Parameters.AddWithValue("@mc_choices", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@mc_choices", mcqchoicestbx.Text);

                        cmd.Parameters.AddWithValue("@type", typetbx.Text);
                        cmd.Parameters.AddWithValue("@subjectID", subjectcb.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@difficultyID", difficultycb.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@gradeID", gardelevelcb.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@cardID", quesIDtbx.Text);

                        // If imageData is null, pass DBNull.Value
                        cmd.Parameters.AddWithValue("@image", imageData == null ? (object)DBNull.Value : imageData);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flashcard updated successfully.");
                            LoadFlashcardDataToGrid();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("No flashcard was updated. Please check the Card ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message);
            }
        }
        



        private void dgvflash_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvflash.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvflash.SelectedRows[0];
                quesIDtbx.Text = row.Cells["card_id"].Value.ToString();
                createquestbx.Text = row.Cells["question"].Value.ToString();
                quesanstbx.Text = row.Cells["answer"].Value.ToString();
                mcqchoicestbx.Text = row.Cells["mca"].Value.ToString();
                typetbx.Text = row.Cells["type"].Value.ToString();


                if (row.Cells["subject_id"] != null)
                    subjectcb.SelectedIndex = Convert.ToInt32(row.Cells["subject_id"].Value) - 1;

                if (row.Cells["difficulty_id"] != null)
                    difficultycb.SelectedIndex = Convert.ToInt32(row.Cells["difficulty_id"].Value) - 1;

                if (row.Cells["grade_id"] != null)
                    gardelevelcb.SelectedIndex = Convert.ToInt32(row.Cells["grade_id"].Value) - 1;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(createquestbx.Text) ||
                  string.IsNullOrWhiteSpace(quesanstbx.Text) ||
                  string.IsNullOrWhiteSpace(typetbx.Text) ||
                  subjectcb.SelectedIndex == -1 ||
                  difficultycb.SelectedIndex == -1 ||
                  gardelevelcb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all fields and select all ComboBoxes.");
                return;
            }

            try
            {
                byte[] imageData = null;

                // Check if an image is selected
                if (pictureBoxFlashcard.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxFlashcard.Image.Save(ms, pictureBoxFlashcard.Image.RawFormat);
                        imageData = ms.ToArray();  // Convert image to byte array
                    }
                }

                using (var connection = _conn.GetConnection())
                {
                    connection.Open();

                    using (var pragma = new SqliteCommand("PRAGMA foreign_keys = ON;", connection))
                    {
                        pragma.ExecuteNonQuery();
                    }

                    string insertQuery = @"INSERT INTO flashCard 
                    (question, answer, mca, mc_choices, type, subject_id, difficulty_id, grade_id, image) 
                    VALUES (@question, @answer, @mca, @mc_choices, @type, @subject_id, @difficulty_id, @grade_id, @image)";

                    using (var cmd = new SqliteCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@question", createquestbx.Text);
                        cmd.Parameters.AddWithValue("@answer", quesanstbx.Text);
                        cmd.Parameters.AddWithValue("@mca", mcqchoicestbx.Text);

                        // Handle optional MCQ choices
                        if (string.IsNullOrWhiteSpace(mcqchoicestbx.Text))
                            cmd.Parameters.AddWithValue("@mc_choices", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@mc_choices", mcqchoicestbx.Text);

                        cmd.Parameters.AddWithValue("@type", typetbx.Text);
                        cmd.Parameters.AddWithValue("@subject_id", subjectcb.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@difficulty_id", difficultycb.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@grade_id", gardelevelcb.SelectedIndex + 1);

                        // If imageData is null, pass DBNull.Value
                        cmd.Parameters.AddWithValue("@image", imageData == null ? (object)DBNull.Value : imageData);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Flashcard added successfully.");
                            LoadFlashcardDataToGrid();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add flashcard.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quesIDtbx.Text))
            {
                MessageBox.Show("Please select a flashcard to delete.");
                return;
            }

            try
            {
                using (var connection = _conn.GetConnection())
                {
                    connection.Open();

                    string query = @"DELETE FROM flashCard WHERE card_id = @cardID";

                    using (var cmd = new SqliteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cardID", quesIDtbx.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flashcard deleted successfully.");
                            LoadFlashcardDataToGrid();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("No flashcard was deleted. Please check the Card ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deletion: " + ex.Message);
            }
        }
        private void ClearInputFields()
        {//resets ComboBoxes
            quesIDtbx.Clear();
            createquestbx.Clear();
            typetbx.Clear();
            quesanstbx.Clear();
            mcqchoicestbx.Clear();
            gardelevelcb.SelectedIndex = -1;
            subjectcb.SelectedIndex = -1;
            difficultycb.SelectedIndex = -1;
        }
        private void LoadFlashcardDataToGrid()
        {
            using (var connection = _conn.GetConnection())
            {
                string query = "SELECT card_id, question, answer, mca, mc_choices, type, subject_id, difficulty_id, grade_id FROM flashCard";

                using (var cmd = new SqliteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dgvflash.DataSource = table;
                }
            }


        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (dgvflash.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvflash.SelectedRows[0];

                quesIDtbx.Text = row.Cells["card_id"].Value.ToString();
                createquestbx.Text = row.Cells["question"].Value.ToString();
                quesanstbx.Text = row.Cells["answer"].Value.ToString();
                mcqchoicestbx.Text = row.Cells["mca"].Value.ToString();
                typetbx.Text = row.Cells["type"].Value.ToString();

                subjectcb.SelectedIndex = Convert.ToInt32(row.Cells["subject_id"].Value) - 1;
                difficultycb.SelectedIndex = Convert.ToInt32(row.Cells["difficulty_id"].Value) - 1;
                gardelevelcb.SelectedIndex = Convert.ToInt32(row.Cells["grade_id"].Value) - 1;


                MessageBox.Show("You can now edit this flashcard. Click 'Update' to save changes.", "Edit Mode");
            }
            else
            {
                MessageBox.Show("Please select a flashcard to edit.", "No Selection");
            }
        }

        private void quesIDtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Flashcard Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFlashcard.Image = Image.FromFile(ofd.FileName);
                    imageData = File.ReadAllBytes(ofd.FileName); // Convert image to byte array
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
