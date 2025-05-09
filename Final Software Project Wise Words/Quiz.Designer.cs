namespace Final_Software_Project_Wise_Words
{
    partial class Quiz
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
            questlearn = new ReaLTaiizor.Controls.RibbonGroupBox();
            picBox = new PictureBox();
            anslabel = new ReaLTaiizor.Controls.NightLabel();
            queslabel = new ReaLTaiizor.Controls.BigLabel();
            prevbtn = new Button();
            nextbtn = new Button();
            exitbtn = new Button();
            panel2 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            finishbtn = new Button();
            panel1 = new Panel();
            ansbtn = new Button();
            choice4 = new RadioButton();
            choice2 = new RadioButton();
            choice3 = new RadioButton();
            choice1 = new RadioButton();
            anstbx = new TextBox();
            choicebox = new GroupBox();
            questlearn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            choicebox.SuspendLayout();
            SuspendLayout();
            // 
            // questlearn
            // 
            questlearn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            questlearn.BackColor = Color.Transparent;
            questlearn.BaseColor = Color.Transparent;
            questlearn.BorderColorA = Color.FromArgb(143, 143, 143);
            questlearn.BorderColorB = Color.FromArgb(174, 178, 172);
            questlearn.BorderColorC = Color.FromArgb(194, 192, 200);
            questlearn.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            questlearn.Controls.Add(picBox);
            questlearn.Controls.Add(anslabel);
            questlearn.Controls.Add(queslabel);
            questlearn.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            questlearn.ForeColor = Color.Black;
            questlearn.LineColorA = Color.FromArgb(126, 126, 126);
            questlearn.LineColorB = Color.FromArgb(126, 126, 126);
            questlearn.Location = new Point(74, 62);
            questlearn.Name = "questlearn";
            questlearn.Size = new Size(858, 334);
            questlearn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            questlearn.TabIndex = 7;
            questlearn.Text = "Questions?";
            // 
            // picBox
            // 
            picBox.Location = new Point(37, 43);
            picBox.Name = "picBox";
            picBox.Size = new Size(769, 151);
            picBox.TabIndex = 2;
            picBox.TabStop = false;
            // 
            // anslabel
            // 
            anslabel.AutoSize = true;
            anslabel.BackColor = Color.Transparent;
            anslabel.Font = new Font("Segoe UI", 9F);
            anslabel.ForeColor = Color.FromArgb(114, 118, 127);
            anslabel.Location = new Point(216, 299);
            anslabel.Name = "anslabel";
            anslabel.Size = new Size(0, 20);
            anslabel.TabIndex = 1;
            // 
            // queslabel
            // 
            queslabel.Anchor = AnchorStyles.None;
            queslabel.AutoSize = true;
            queslabel.BackColor = Color.Transparent;
            queslabel.Font = new Font("Segoe UI", 25F);
            queslabel.ForeColor = Color.FromArgb(80, 80, 80);
            queslabel.Location = new Point(90, 211);
            queslabel.Name = "queslabel";
            queslabel.Size = new Size(0, 57);
            queslabel.TabIndex = 0;
            // 
            // prevbtn
            // 
            prevbtn.Anchor = AnchorStyles.Left;
            prevbtn.BackColor = Color.FromArgb(192, 255, 255);
            prevbtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevbtn.Location = new Point(3, 5);
            prevbtn.Name = "prevbtn";
            prevbtn.Size = new Size(116, 51);
            prevbtn.TabIndex = 3;
            prevbtn.Text = "Previous";
            prevbtn.UseVisualStyleBackColor = false;
            prevbtn.Click += prevbtn_Click;
            // 
            // nextbtn
            // 
            nextbtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nextbtn.BackColor = Color.FromArgb(192, 255, 255);
            nextbtn.Font = new Font("MS UI Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextbtn.Location = new Point(881, 3);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(116, 51);
            nextbtn.TabIndex = 4;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = false;
            nextbtn.Click += nextbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.Transparent;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbtn.ForeColor = Color.Red;
            exitbtn.Location = new Point(0, 3);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(72, 34);
            exitbtn.TabIndex = 4;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(nightControlBox1);
            panel2.Controls.Add(finishbtn);
            panel2.Controls.Add(exitbtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 42);
            panel2.TabIndex = 9;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.Black;
            nightControlBox1.CloseHoverForeColor = Color.Black;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.Black;
            nightControlBox1.DisableMinimizeColor = Color.Black;
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.Black;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(861, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 6;
            // 
            // finishbtn
            // 
            finishbtn.Anchor = AnchorStyles.None;
            finishbtn.BackColor = Color.Lime;
            finishbtn.FlatStyle = FlatStyle.Flat;
            finishbtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishbtn.ForeColor = Color.Black;
            finishbtn.Location = new Point(453, 3);
            finishbtn.Name = "finishbtn";
            finishbtn.Size = new Size(93, 34);
            finishbtn.TabIndex = 5;
            finishbtn.Text = "Finish Quiz";
            finishbtn.UseVisualStyleBackColor = false;
            finishbtn.Click += finishbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(ansbtn);
            panel1.Controls.Add(prevbtn);
            panel1.Controls.Add(nextbtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 544);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 56);
            panel1.TabIndex = 8;
            // 
            // ansbtn
            // 
            ansbtn.Anchor = AnchorStyles.None;
            ansbtn.BackColor = Color.FromArgb(192, 255, 255);
            ansbtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ansbtn.Location = new Point(453, 2);
            ansbtn.Name = "ansbtn";
            ansbtn.Size = new Size(116, 51);
            ansbtn.TabIndex = 10;
            ansbtn.Text = "Answer";
            ansbtn.UseVisualStyleBackColor = false;
            ansbtn.Click += ansbtn_Click;
            // 
            // choice4
            // 
            choice4.AutoSize = true;
            choice4.Location = new Point(506, 64);
            choice4.Name = "choice4";
            choice4.Size = new Size(17, 16);
            choice4.TabIndex = 3;
            choice4.TabStop = true;
            choice4.UseVisualStyleBackColor = true;
            // 
            // choice2
            // 
            choice2.AutoSize = true;
            choice2.Location = new Point(90, 64);
            choice2.Name = "choice2";
            choice2.Size = new Size(17, 16);
            choice2.TabIndex = 2;
            choice2.TabStop = true;
            choice2.UseVisualStyleBackColor = true;
            // 
            // choice3
            // 
            choice3.AutoSize = true;
            choice3.Location = new Point(506, 26);
            choice3.Name = "choice3";
            choice3.Size = new Size(17, 16);
            choice3.TabIndex = 1;
            choice3.TabStop = true;
            choice3.UseVisualStyleBackColor = true;
            // 
            // choice1
            // 
            choice1.AutoSize = true;
            choice1.Location = new Point(90, 26);
            choice1.Name = "choice1";
            choice1.Size = new Size(17, 16);
            choice1.TabIndex = 0;
            choice1.TabStop = true;
            choice1.UseVisualStyleBackColor = true;
            // 
            // anstbx
            // 
            anstbx.Anchor = AnchorStyles.None;
            anstbx.Location = new Point(164, 404);
            anstbx.Name = "anstbx";
            anstbx.Size = new Size(622, 27);
            anstbx.TabIndex = 11;
            // 
            // choicebox
            // 
            choicebox.Anchor = AnchorStyles.None;
            choicebox.BackColor = Color.GreenYellow;
            choicebox.Controls.Add(choice4);
            choicebox.Controls.Add(choice1);
            choicebox.Controls.Add(choice3);
            choicebox.Controls.Add(choice2);
            choicebox.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            choicebox.Location = new Point(100, 437);
            choicebox.Name = "choicebox";
            choicebox.Size = new Size(802, 103);
            choicebox.TabIndex = 12;
            choicebox.TabStop = false;
            choicebox.Text = "Choices";
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1000, 600);
            Controls.Add(choicebox);
            Controls.Add(anstbx);
            Controls.Add(questlearn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 481);
            Name = "Quiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            questlearn.ResumeLayout(false);
            questlearn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            choicebox.ResumeLayout(false);
            choicebox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.RibbonGroupBox questlearn;
        private ReaLTaiizor.Controls.NightLabel anslabel;
        private ReaLTaiizor.Controls.BigLabel queslabel;
        private Button prevbtn;
        private Button nextbtn;
        private Button exitbtn;
        private Panel panel2;
        private Panel panel1;
        private Button ansbtn;
        private RadioButton choice4;
        private RadioButton choice2;
        private RadioButton choice3;
        private RadioButton choice1;
        private TextBox anstbx;
        private Button finishbtn;
        private GroupBox choicebox;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox picBox;
    }
}