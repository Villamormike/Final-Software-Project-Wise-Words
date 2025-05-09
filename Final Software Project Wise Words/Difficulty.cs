using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Software_Project_Wise_Words
{
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
            InitializeControls();
            LoadSubjects();

        }
        private void LoadSubjects()
        {
            subject.Items.AddRange(new object[] { "Math", "Science", "English" });
            subject.SelectedIndex = 0; // Select first by default
        }


        private void InitializeControls()
        {
            // Set up grade levels
            gradelvl.Items.AddRange(new object[] {
                "Kindergarten", "Grade 1", "Grade 2",
                "Grade 3", "Grade 4", "Grade 5", "Grade 6"
            });
            gradelvl.SelectedIndex = 0;

            // Load subjects from database
            LoadSubjects();

            // Set default difficulty
            easyrad.Checked = true;
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            Difficulty_Selection.SelectedDifficulty = easyrad.Checked ? "Easy" :
                                moderaterad.Checked ? "Moderate" :
                                hardrad.Checked ? "Hard" : "";

            Difficulty_Selection.SelectedGrade = gradelvl.SelectedItem?.ToString();
            Difficulty_Selection.SelectedSubject = subject.SelectedItem?.ToString();

            if (!Difficulty_Selection.IsSelectionComplete())
            {
                MessageBox.Show("Please select all required options before proceeding.",
                                "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (User.LoggedInUser != null)
            {
                UserSelection.SaveUserSelection(
                    User.LoggedInUser.UserID,
                    Difficulty_Selection.SelectedGrade,
                    Difficulty_Selection.SelectedSubject,
                    Difficulty_Selection.SelectedDifficulty
                );
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
  }
 

