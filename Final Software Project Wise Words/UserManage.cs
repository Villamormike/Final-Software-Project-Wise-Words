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

namespace Final_Software_Project_Wise_Words
{
    public partial class UserManage : Form
    {

        public UserManage()
        {
            InitializeComponent();
            LoadUsers();
            dgvuser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvuser.MultiSelect = false;
            dgvuser.ReadOnly = true;
            dgvuser.AllowUserToAddRows = false;
            dgvuser.AllowUserToDeleteRows = false;
        }
        private void LoadUsers()
        {
            dgvuser.Rows.Clear();
            dgvuser.Columns.Clear();

            dgvuser.Columns.Add("user_id", "User ID");
            dgvuser.Columns.Add("username", "Username");
            dgvuser.Columns.Add("difficulty", "Difficulty");
            dgvuser.Columns.Add("gradelevel", "Grade Level");
            dgvuser.Columns.Add("subject", "Subject Taken");

            string query = @"
                SELECT 
                    a.user_id,
                    a.username,
                    d.level_name AS difficulty,
                    g.grade_name AS gradelevel,
                    s.subject_name AS subject
                FROM accounts a
                JOIN config_user c ON a.user_id = c.user_id
                JOIN difficulty d ON c.difficulty_id = d.difficulty_id
                JOIN gradeLevel g ON c.grade_id = g.grade_id
                JOIN subject s ON c.subject_id = s.subject_id;
            ";

            using (var connection = new Database.DatabaseConnection().GetConnection())
            {
                using (var command = new SqliteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvuser.Rows.Add(
                            reader["user_id"].ToString(),
                            reader["username"].ToString(),
                            reader["difficulty"].ToString(),
                            reader["gradelevel"].ToString(),
                            reader["subject"].ToString()
                        );
                    }
                }
            }

        }

        private void dgvuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void deltbtn_Click(object sender, EventArgs e)
        {
            if (dgvuser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvuser.SelectedRows[0].Cells["user_id"].Value);

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete user ID {selectedUserId}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var conn = new Database.DatabaseConnection().GetConnection())
                {
                    string deleteQuery = "DELETE FROM accounts WHERE user_id = @userId";
                    using (var cmd = new SqliteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", selectedUserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadUsers(); // Refresh after deletion
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string username = searchusertbx.Text.Trim();
            string userId = useridtbx.Text.Trim();

            using (var conn = new Database.DatabaseConnection().GetConnection())
            {
                string query = "SELECT user_id, username, account_level, date_created, last_login FROM accounts WHERE 1=1";
                if (!string.IsNullOrEmpty(username))
                    query += " AND username LIKE @username";
                if (!string.IsNullOrEmpty(userId))
                    query += " AND user_id = @userId";

                using (var cmd = new SqliteCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(username))
                        cmd.Parameters.AddWithValue("@username", "%" + username + "%");

                    if (!string.IsNullOrEmpty(userId) && int.TryParse(userId, out int id))
                        cmd.Parameters.AddWithValue("@userId", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvuser.DataSource = dt;
                    }
                }
            }
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
