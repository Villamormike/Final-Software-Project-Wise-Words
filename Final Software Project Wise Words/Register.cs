using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.Sqlite;
using Microsoft.Win32;
using static Final_Software_Project_Wise_Words.Database;

namespace Final_Software_Project_Wise_Words
{
    public partial class register : Form

    {
        private readonly DatabaseConnection _conn;
        private bool resizing = false;
        private bool moving = false;
        private Point lastMousePosition;
        private Point moveStartPosition;
        private int resizeMargin = 10;
        private int edge = 0;
        private static List<User> users = new List<User>();
        public register()
        {

            InitializeComponent();
            _conn = new DatabaseConnection();
            passtbx.PasswordChar = '*';
            confirmpasstbx.PasswordChar = '*';
            this.MouseDown += register_MouseDown;
            this.MouseMove += register_MouseMove;
            this.MouseUp += register_MouseUp;
            this.DoubleBuffered = true;
        }

        private void register_MouseDown(object sender, MouseEventArgs e)
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

        private void register_MouseMove(object sender, MouseEventArgs e)
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

        private void register_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
            moving = false;
            this.Cursor = Cursors.Default;
        }


        private void regbtn_Click(object sender, EventArgs e)
        {
            string username = usertbx.Text.Trim();
            string password = passtbx.Text.Trim();
            string confirmPassword = confirmpasstbx.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = _conn.GetConnection())
            {
                try
                {
                    // check is username exists
                    string checkQuery = "SELECT COUNT(*) FROM accounts WHERE username = @username";
                    using (var checkCmd = new SqliteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // insert new user
                    string insertQuery = "INSERT INTO accounts (username, password, account_level, date_created) " +
                                         "VALUES (@username, @password, 'USER', datetime('now'))";

                    using (var insertCmd = new SqliteCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }

        }
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            passtbx.PasswordChar = showpass.Checked ? '\0' : '*';
            confirmpasstbx.PasswordChar = showpass.Checked ? '\0' : '*';
        }


        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }
        public static List<User> GetUsers()
        {
            return users;
        }
        private Point _mouseDownLocation;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownLocation = e.Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - _mouseDownLocation.X;
                this.Top = e.Y + this.Top - _mouseDownLocation.Y;
            }
        }
    }
}
