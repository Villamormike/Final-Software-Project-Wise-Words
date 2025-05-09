namespace Final_Software_Project_Wise_Words
{
    partial class Difficulty
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
            thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            hardrad = new RadioButton();
            moderaterad = new RadioButton();
            easyrad = new RadioButton();
            gradelvl = new ComboBox();
            subject = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            confirmbtn = new Button();
            panel2 = new Panel();
            thunderGroupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // thunderGroupBox1
            // 
            thunderGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            thunderGroupBox1.BackColor = Color.Transparent;
            thunderGroupBox1.BodyColorA = Color.FromArgb(192, 255, 255);
            thunderGroupBox1.BodyColorB = Color.FromArgb(192, 255, 255);
            thunderGroupBox1.BodyColorC = Color.Lime;
            thunderGroupBox1.BodyColorD = Color.Red;
            thunderGroupBox1.Controls.Add(hardrad);
            thunderGroupBox1.Controls.Add(moderaterad);
            thunderGroupBox1.Controls.Add(easyrad);
            thunderGroupBox1.ForeColor = Color.Black;
            thunderGroupBox1.Location = new Point(12, 52);
            thunderGroupBox1.Name = "thunderGroupBox1";
            thunderGroupBox1.Size = new Size(203, 217);
            thunderGroupBox1.TabIndex = 0;
            thunderGroupBox1.Text = "Difficulty";
            // 
            // hardrad
            // 
            hardrad.AutoSize = true;
            hardrad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hardrad.Location = new Point(22, 150);
            hardrad.Name = "hardrad";
            hardrad.Size = new Size(85, 35);
            hardrad.TabIndex = 2;
            hardrad.TabStop = true;
            hardrad.Text = "Hard";
            hardrad.UseVisualStyleBackColor = true;
            // 
            // moderaterad
            // 
            moderaterad.AutoSize = true;
            moderaterad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moderaterad.Location = new Point(22, 93);
            moderaterad.Name = "moderaterad";
            moderaterad.Size = new Size(135, 35);
            moderaterad.TabIndex = 1;
            moderaterad.TabStop = true;
            moderaterad.Text = "Moderate";
            moderaterad.UseVisualStyleBackColor = true;
            // 
            // easyrad
            // 
            easyrad.AutoSize = true;
            easyrad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            easyrad.Location = new Point(22, 37);
            easyrad.Name = "easyrad";
            easyrad.Size = new Size(80, 35);
            easyrad.TabIndex = 0;
            easyrad.TabStop = true;
            easyrad.Text = "Easy";
            easyrad.UseVisualStyleBackColor = true;
            // 
            // gradelvl
            // 
            gradelvl.Anchor = AnchorStyles.Right;
            gradelvl.FormattingEnabled = true;
            gradelvl.Location = new Point(429, 52);
            gradelvl.Name = "gradelvl";
            gradelvl.Size = new Size(242, 28);
            gradelvl.TabIndex = 1;
            // 
            // subject
            // 
            subject.Anchor = AnchorStyles.Right;
            subject.FormattingEnabled = true;
            subject.Location = new Point(429, 177);
            subject.Name = "subject";
            subject.Size = new Size(242, 28);
            subject.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 60);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 3;
            label1.Text = "Choose Grade Level:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 185);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 4;
            label2.Text = "Choose Subjects:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(bigLabel1);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 46);
            panel1.TabIndex = 5;
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.Left;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DarkGreen;
            bigLabel1.Location = new Point(0, 8);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(325, 28);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "CHOOSE A DIFFICULTY";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(565, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // confirmbtn
            // 
            confirmbtn.Anchor = AnchorStyles.None;
            confirmbtn.BackColor = Color.FromArgb(192, 255, 255);
            confirmbtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmbtn.Location = new Point(221, 3);
            confirmbtn.Name = "confirmbtn";
            confirmbtn.Size = new Size(266, 63);
            confirmbtn.TabIndex = 6;
            confirmbtn.Text = "Confirm";
            confirmbtn.UseVisualStyleBackColor = false;
            confirmbtn.Click += confirmbtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(confirmbtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 69);
            panel2.TabIndex = 7;
            // 
            // Difficulty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(704, 384);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(subject);
            Controls.Add(gradelvl);
            Controls.Add(thunderGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(704, 384);
            Name = "Difficulty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Difficulty";
            thunderGroupBox1.ResumeLayout(false);
            thunderGroupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private ComboBox gradelvl;
        private ComboBox subject;
        private RadioButton hardrad;
        private RadioButton moderaterad;
        private RadioButton easyrad;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button confirmbtn;
        private Panel panel2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}