using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Final_Software_Project_Wise_Words
{
    public partial class Leaderboard : Form
    {
        private Database.DatabaseConnection _conn;
        public Leaderboard()
        {
            InitializeComponent();
            _conn = new Database.DatabaseConnection();
            

        }
        private void InitializeListViewColumns()
        {
            leaderboardview.View = View.Details;
            leaderboardview.FullRowSelect = true;
            leaderboardview.Columns.Clear();

            leaderboardview.Columns.Add("Rank", 50);
            leaderboardview.Columns.Add("Username", 100);
            leaderboardview.Columns.Add("Score", 70);
            leaderboardview.Columns.Add("Subject", 100);
            leaderboardview.Columns.Add("Level", 100);
            leaderboardview.Columns.Add("Grade", 100);
            leaderboardview.Columns.Add("Date Achieved", 130);
            
        }


        private void refbtn_Click(object sender, EventArgs e)
        {
            InitializeListViewColumns();
            LoadLeaderboard();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }
        private void LoadLeaderboard()
        {
            if (User.LoggedInUser == null)
            {
                MessageBox.Show("Username is not set. Please log in again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                new Login().Show();
                return;
            }

            leaderboardview.Items.Clear();
            InitializeListViewColumns(); // Make sure columns are refreshed

            try
            {
                using (var connection = _conn.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    username,
                    MAX(score) AS score,
                    subject_name,
                    level_name,
                    grade_name,
                    MAX(strftime('%Y-%m-%d %H:%M', date_taken)) AS Date_Achieved
                FROM leaderboard
                GROUP BY username, subject_name, level_name, grade_name
                ORDER BY score DESC
                LIMIT 50";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            int rank = 1;
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(rank.ToString());
                                item.SubItems.Add(reader["username"].ToString());
                                item.SubItems.Add(reader["score"].ToString());
                                item.SubItems.Add(reader["subject_name"].ToString());
                                item.SubItems.Add(reader["level_name"].ToString());
                                item.SubItems.Add(reader["grade_name"].ToString());
                                item.SubItems.Add(reader["Date_Achieved"].ToString());

                                if (reader["username"].ToString() == User.LoggedInUser.Username)
                                {
                                    item.BackColor = Color.LightBlue;
                                    item.Font = new Font(item.Font, FontStyle.Bold);
                                }

                                leaderboardview.Items.Add(item);
                                rank++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leaderboard: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void listLeaderboard_SelectedIndexChanged(object sender)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menuForm = new Menu();
            menuForm.Show();
        }
    }
}
