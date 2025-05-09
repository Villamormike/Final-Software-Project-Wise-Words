namespace Final_Software_Project_Wise_Words
{
    partial class Learn
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
            picture = new PictureBox();
            anslabel = new ReaLTaiizor.Controls.NightLabel();
            queslabel = new ReaLTaiizor.Controls.BigLabel();
            prevbtn = new Button();
            nextbtn = new Button();
            backbtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            questlearn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            questlearn.Controls.Add(picture);
            questlearn.Controls.Add(anslabel);
            questlearn.Controls.Add(queslabel);
            questlearn.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            questlearn.ForeColor = Color.Black;
            questlearn.LineColorA = Color.FromArgb(126, 126, 126);
            questlearn.LineColorB = Color.FromArgb(126, 126, 126);
            questlearn.Location = new Point(36, 68);
            questlearn.Name = "questlearn";
            questlearn.Size = new Size(928, 400);
            questlearn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            questlearn.TabIndex = 1;
            questlearn.Text = "Questions?";
            // 
            // picture
            // 
            picture.Location = new Point(18, 112);
            picture.Name = "picture";
            picture.Size = new Size(888, 168);
            picture.SizeMode = PictureBoxSizeMode.CenterImage;
            picture.TabIndex = 2;
            picture.TabStop = false;
            // 
            // anslabel
            // 
            anslabel.Anchor = AnchorStyles.None;
            anslabel.AutoSize = true;
            anslabel.BackColor = Color.Transparent;
            anslabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            anslabel.ForeColor = Color.FromArgb(114, 118, 127);
            anslabel.Location = new Point(345, 357);
            anslabel.Name = "anslabel";
            anslabel.Size = new Size(0, 25);
            anslabel.TabIndex = 1;
            anslabel.Click += anslabel_Click;
            // 
            // queslabel
            // 
            queslabel.Anchor = AnchorStyles.None;
            queslabel.AutoSize = true;
            queslabel.BackColor = Color.Transparent;
            queslabel.Font = new Font("Segoe UI", 25F);
            queslabel.ForeColor = Color.FromArgb(80, 80, 80);
            queslabel.Location = new Point(73, 39);
            queslabel.Name = "queslabel";
            queslabel.Size = new Size(0, 57);
            queslabel.TabIndex = 0;
            // 
            // prevbtn
            // 
            prevbtn.Anchor = AnchorStyles.Left;
            prevbtn.BackColor = Color.FromArgb(192, 255, 255);
            prevbtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevbtn.Location = new Point(3, 0);
            prevbtn.Name = "prevbtn";
            prevbtn.Size = new Size(106, 51);
            prevbtn.TabIndex = 3;
            prevbtn.Text = "Previous";
            prevbtn.UseVisualStyleBackColor = false;
            prevbtn.Click += prevbtn_Click;
            // 
            // nextbtn
            // 
            nextbtn.Anchor = AnchorStyles.Right;
            nextbtn.BackColor = Color.FromArgb(192, 255, 255);
            nextbtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextbtn.Location = new Point(890, 0);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(106, 51);
            nextbtn.TabIndex = 4;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = false;
            nextbtn.Click += nextbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Anchor = AnchorStyles.Left;
            backbtn.BackColor = Color.Transparent;
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.ForeColor = Color.Red;
            backbtn.Location = new Point(3, 5);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(74, 34);
            backbtn.TabIndex = 4;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(prevbtn);
            panel1.Controls.Add(nextbtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 474);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 72);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(nightControlBox1);
            panel2.Controls.Add(backbtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 42);
            panel2.TabIndex = 6;
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
            nightControlBox1.Location = new Point(861, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 5;
            // 
            // Learn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 546);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(questlearn);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 481);
            Name = "Learn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learn";
            questlearn.ResumeLayout(false);
            questlearn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.RibbonGroupBox questlearn;
        private ReaLTaiizor.Controls.BigLabel queslabel;
        private Button prevbtn;
        private Button nextbtn;
        private Button backbtn;
        private ReaLTaiizor.Controls.NightLabel anslabel;
        private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox picture;
    }
}