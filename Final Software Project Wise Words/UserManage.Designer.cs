namespace Final_Software_Project_Wise_Words
{
    partial class UserManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            thunderControlBox1 = new ReaLTaiizor.Controls.ThunderControlBox();
            gradeleveltbx = new TextBox();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            useridtbx = new TextBox();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            searchsubtbx = new TextBox();
            searchsubject = new ReaLTaiizor.Controls.DungeonLabel();
            searchbtn = new ReaLTaiizor.Controls.Button();
            deltbtn = new ReaLTaiizor.Controls.Button();
            searchusertbx = new TextBox();
            searchuser = new ReaLTaiizor.Controls.DungeonLabel();
            dgvuser = new DataGridView();
            backbtn = new ReaLTaiizor.Controls.Button();
            formTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvuser).BeginInit();
            SuspendLayout();
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.White;
            formTheme1.Controls.Add(backbtn);
            formTheme1.Controls.Add(thunderControlBox1);
            formTheme1.Controls.Add(gradeleveltbx);
            formTheme1.Controls.Add(dungeonLabel2);
            formTheme1.Controls.Add(useridtbx);
            formTheme1.Controls.Add(dungeonLabel1);
            formTheme1.Controls.Add(searchsubtbx);
            formTheme1.Controls.Add(searchsubject);
            formTheme1.Controls.Add(searchbtn);
            formTheme1.Controls.Add(deltbtn);
            formTheme1.Controls.Add(searchusertbx);
            formTheme1.Controls.Add(searchuser);
            formTheme1.Controls.Add(dgvuser);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 8F);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 28, 3, 28);
            formTheme1.Sizable = true;
            formTheme1.Size = new Size(1357, 450);
            formTheme1.SmartBounds = false;
            formTheme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            formTheme1.TabIndex = 0;
            formTheme1.Text = "Users Management";
            // 
            // thunderControlBox1
            // 
            thunderControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            thunderControlBox1.BackColor = Color.Transparent;
            thunderControlBox1.DefaultLocation = true;
            thunderControlBox1.ForeColor = Color.FromArgb(174, 195, 30);
            thunderControlBox1.Location = new Point(1279, 3);
            thunderControlBox1.Name = "thunderControlBox1";
            thunderControlBox1.Size = new Size(75, 23);
            thunderControlBox1.TabIndex = 18;
            thunderControlBox1.Text = "thunderControlBox1";
            // 
            // gradeleveltbx
            // 
            gradeleveltbx.Location = new Point(733, 306);
            gradeleveltbx.Name = "gradeleveltbx";
            gradeleveltbx.Size = new Size(379, 25);
            gradeleveltbx.TabIndex = 15;
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 11F);
            dungeonLabel2.ForeColor = Color.White;
            dungeonLabel2.Location = new Point(550, 306);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(177, 25);
            dungeonLabel2.TabIndex = 14;
            dungeonLabel2.Text = "Search Grade Level:";
            // 
            // useridtbx
            // 
            useridtbx.Location = new Point(146, 306);
            useridtbx.Name = "useridtbx";
            useridtbx.Size = new Size(379, 25);
            useridtbx.TabIndex = 13;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 11F);
            dungeonLabel1.ForeColor = Color.White;
            dungeonLabel1.Location = new Point(6, 306);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(134, 25);
            dungeonLabel1.TabIndex = 12;
            dungeonLabel1.Text = "Search UserID:";
            // 
            // searchsubtbx
            // 
            searchsubtbx.Location = new Point(733, 268);
            searchsubtbx.Name = "searchsubtbx";
            searchsubtbx.Size = new Size(379, 25);
            searchsubtbx.TabIndex = 11;
            // 
            // searchsubject
            // 
            searchsubject.AutoSize = true;
            searchsubject.BackColor = Color.Transparent;
            searchsubject.Font = new Font("Segoe UI", 11F);
            searchsubject.ForeColor = Color.White;
            searchsubject.Location = new Point(550, 268);
            searchsubject.Name = "searchsubject";
            searchsubject.Size = new Size(140, 25);
            searchsubject.TabIndex = 10;
            searchsubject.Text = "Search Subject:";
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Transparent;
            searchbtn.BorderColor = Color.FromArgb(32, 34, 37);
            searchbtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            searchbtn.EnteredColor = Color.FromArgb(32, 34, 37);
            searchbtn.Font = new Font("Microsoft Sans Serif", 12F);
            searchbtn.Image = null;
            searchbtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchbtn.InactiveColor = Color.FromArgb(32, 34, 37);
            searchbtn.Location = new Point(550, 353);
            searchbtn.Name = "searchbtn";
            searchbtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            searchbtn.PressedColor = Color.FromArgb(165, 37, 37);
            searchbtn.Size = new Size(150, 50);
            searchbtn.TabIndex = 9;
            searchbtn.Text = "Search";
            searchbtn.TextAlignment = StringAlignment.Center;
            searchbtn.Click += searchbtn_Click;
            // 
            // deltbtn
            // 
            deltbtn.BackColor = Color.Transparent;
            deltbtn.BorderColor = Color.FromArgb(32, 34, 37);
            deltbtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            deltbtn.EnteredColor = Color.FromArgb(32, 34, 37);
            deltbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deltbtn.Image = null;
            deltbtn.ImageAlign = ContentAlignment.MiddleLeft;
            deltbtn.InactiveColor = Color.FromArgb(32, 34, 37);
            deltbtn.Location = new Point(733, 353);
            deltbtn.Name = "deltbtn";
            deltbtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            deltbtn.PressedColor = Color.FromArgb(165, 37, 37);
            deltbtn.Size = new Size(150, 50);
            deltbtn.TabIndex = 8;
            deltbtn.Text = "Delete";
            deltbtn.TextAlignment = StringAlignment.Center;
            deltbtn.Click += deltbtn_Click;
            // 
            // searchusertbx
            // 
            searchusertbx.Location = new Point(146, 268);
            searchusertbx.Name = "searchusertbx";
            searchusertbx.Size = new Size(379, 25);
            searchusertbx.TabIndex = 6;
            // 
            // searchuser
            // 
            searchuser.AutoSize = true;
            searchuser.BackColor = Color.Transparent;
            searchuser.Font = new Font("Segoe UI", 11F);
            searchuser.ForeColor = Color.White;
            searchuser.Location = new Point(5, 268);
            searchuser.Name = "searchuser";
            searchuser.Size = new Size(116, 25);
            searchuser.TabIndex = 5;
            searchuser.Text = "Search User:";
            // 
            // dgvuser
            // 
            dgvuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvuser.Dock = DockStyle.Top;
            dgvuser.Location = new Point(3, 28);
            dgvuser.Name = "dgvuser";
            dgvuser.RowHeadersWidth = 51;
            dgvuser.Size = new Size(1351, 219);
            dgvuser.TabIndex = 0;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.Transparent;
            backbtn.BorderColor = Color.FromArgb(32, 34, 37);
            backbtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            backbtn.EnteredColor = Color.FromArgb(32, 34, 37);
            backbtn.Font = new Font("Microsoft Sans Serif", 12F);
            backbtn.Image = null;
            backbtn.ImageAlign = ContentAlignment.MiddleLeft;
            backbtn.InactiveColor = Color.FromArgb(32, 34, 37);
            backbtn.Location = new Point(375, 353);
            backbtn.Name = "backbtn";
            backbtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            backbtn.PressedColor = Color.FromArgb(165, 37, 37);
            backbtn.Size = new Size(150, 50);
            backbtn.TabIndex = 19;
            backbtn.Text = "Back";
            backbtn.TextAlignment = StringAlignment.Center;
            backbtn.Click += backbtn_Click;
            // 
            // UserManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 450);
            Controls.Add(formTheme1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "UserManage";
            Text = "Users Management";
            TransparencyKey = Color.Fuchsia;
            Load += UserManagement_Load;
            formTheme1.ResumeLayout(false);
            formTheme1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvuser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private DataGridView dgvuser;
        private TextBox searchsubtbx;
        private ReaLTaiizor.Controls.DungeonLabel searchsubject;
        private ReaLTaiizor.Controls.Button searchbtn;
        private ReaLTaiizor.Controls.Button deltbtn;
        private TextBox searchusertbx;
        private ReaLTaiizor.Controls.DungeonLabel searchuser;
        private TextBox gradeleveltbx;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private TextBox useridtbx;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.ThunderControlBox thunderControlBox1;
        private ReaLTaiizor.Controls.Button backbtn;
    }
}