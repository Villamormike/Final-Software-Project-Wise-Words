using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Final_Software_Project_Wise_Words
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

        }

        private void flashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlashCardCRUD flashManagementForm = new FlashCardCRUD();
            flashManagementForm.Show();
            flashManagementForm.FormClosed += (s, args) => this.Close();
        }

        private void userdetailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManage userManageForm = new UserManage();
            userManageForm.Show();
            userManageForm.FormClosed += (s, args) => this.Close();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
            loginForm.FormClosed += (s, args) => this.Close();
        }
    }
}
