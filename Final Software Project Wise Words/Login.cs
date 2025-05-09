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
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Final_Software_Project_Wise_Words.Database;

namespace Final_Software_Project_Wise_Words
{   
    public partial class Login : Form
    {
     
        private readonly DatabaseConnection _conn;
        private bool resizing = false;
        private bool moving = false;
        private Point lastMousePosition;
        private Point moveStartPosition;
        private int resizeMargin = 10;
        private int edge = 0;
        public Login()
        {
            InitializeComponent();
            passtbx.PasswordChar = '*';
            this.MouseDown += Login_MouseDown;
            this.MouseMove += Login_MouseMove;
            this.MouseUp += Login_MouseUp;
            this.DoubleBuffered = true;
            _conn = new DatabaseConnection();
           

        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (edge != 0)
            {
                resizing = true;
                lastMousePosition = e.Location;
            }
            else
            {
                moving = true;
                moveStartPosition = e.Location;
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
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
            else if (moving)
            {
                this.Left += e.X - moveStartPosition.X;
                this.Top += e.Y - moveStartPosition.Y;
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

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
            moving = false;
            this.Cursor = Cursors.Default;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usertbx.Text.Trim();
            string password = passtbx.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = _conn.GetConnection())
            {
                string query = "SELECT * FROM accounts WHERE username = @username AND password = @password";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store the user globally
                                User.LoggedInUser = new User
                                {
                                    UserID = Convert.ToInt32(reader["user_id"]),
                                    Username = reader["username"].ToString(),
                                    AccountLevel = reader["account_level"].ToString(),
                                    LastLogin = reader["last_login"] == DBNull.Value
                                        ? null
                                        : Convert.ToDateTime(reader["last_login"])
                                };

                                MessageBox.Show("Welcome " + User.LoggedInUser.Username,
                                    "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Update login timestamp
                                string updateQuery = "UPDATE accounts SET last_login = datetime('now') WHERE username = @username";
                                using (var updateCommand = new SqliteCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@username", username);
                                    updateCommand.ExecuteNonQuery();
                                }

                                // Redirect
                                if (User.LoggedInUser.AccountLevel.ToUpper() == "ADMIN")
                                {
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.Show();
                                }
                                else
                                {
                                    Menu menuForm = new Menu();
                                    menuForm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.",
                                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception loginErr)
                    {
                        MessageBox.Show(loginErr.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            passtbx.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void createlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
            this.Hide();
        }
    }
}
