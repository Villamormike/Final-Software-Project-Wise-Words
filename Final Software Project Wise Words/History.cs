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
    public partial class History : Form
    {
        private Database.DatabaseConnection _conn;
        public History()
        {
            InitializeComponent();
            _conn = new Database.DatabaseConnection();
            LoadUserHistory();

        }

        private void crownListView1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeListViewColumns()
        {
            // Set up the ListView for displaying the user history
            hisview.View = View.Details;
            hisview.FullRowSelect = true;
            hisview.Columns.Clear();

            // Define the columns for the ListView
            hisview.Columns.Add("Activity", 150);
            hisview.Columns.Add("Details", 250);
            hisview.Columns.Add("Date Achieved", 130);
        }

        private void LoadUserHistory()
        {
            if (User.LoggedInUser == null)
            {
                MessageBox.Show("No user logged in. Please log in again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                new Login().Show();
                return;
            }

            // Clear any existing items in the ListView
            hisview.Items.Clear();

            // Initialize columns to ensure they are set correctly
            InitializeListViewColumns();

            try
            {
                using (var connection = _conn.GetConnection())
                {
                    connection.Open();

                    // SQL query to get user history from the database
                    string query = @"
                    SELECT 
                        activity,
                        details,
                        strftime('%Y-%m-%d %H:%M', activity_date) AS Date_Achieved
                    FROM user_history
                    WHERE user_id = @userId
                    ORDER BY activity_date DESC";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", User.LoggedInUser.UserID);

                        using (var reader = command.ExecuteReader())
                        {
                            // Iterate through the data and add it to the ListView
                            while (reader.Read())
                            {
                                // Create a new ListViewItem for each row
                                ListViewItem item = new ListViewItem(reader["activity"].ToString());
                                item.SubItems.Add(reader["details"].ToString());
                                item.SubItems.Add(reader["Date_Achieved"].ToString());

                                // Optionally highlight the logged-in user's activities
                                if (reader["activity"].ToString() == "Some Activity of Interest") // Modify based on your needs
                                {
                                    item.BackColor = Color.LightBlue;
                                    item.Font = new Font(item.Font, FontStyle.Bold);
                                }

                                // Add the item to the ListView
                                hisview.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadUserHistory();
        }
    }
}

