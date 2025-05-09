namespace Final_Software_Project_Wise_Words
{
    partial class AdminForm
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
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            admin = new Label();
            userdetailsbtn = new Button();
            logbtn = new Button();
            flashbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(admin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 54);
            panel1.TabIndex = 0;
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
            nightControlBox1.Location = new Point(744, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // admin
            // 
            admin.AutoSize = true;
            admin.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin.ForeColor = SystemColors.ButtonHighlight;
            admin.Location = new Point(3, 9);
            admin.Name = "admin";
            admin.Size = new Size(239, 37);
            admin.TabIndex = 0;
            admin.Text = "Administrator";
            // 
            // userdetailsbtn
            // 
            userdetailsbtn.BackColor = Color.Black;
            userdetailsbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userdetailsbtn.ForeColor = SystemColors.ButtonHighlight;
            userdetailsbtn.Location = new Point(370, 201);
            userdetailsbtn.Name = "userdetailsbtn";
            userdetailsbtn.Size = new Size(274, 62);
            userdetailsbtn.TabIndex = 1;
            userdetailsbtn.Text = "UserDetails";
            userdetailsbtn.UseVisualStyleBackColor = false;
            userdetailsbtn.Click += userdetailsbtn_Click;
            // 
            // logbtn
            // 
            logbtn.BackColor = Color.Black;
            logbtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logbtn.ForeColor = SystemColors.ButtonFace;
            logbtn.Location = new Point(370, 291);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(274, 63);
            logbtn.TabIndex = 2;
            logbtn.Text = "Logout";
            logbtn.UseVisualStyleBackColor = false;
            logbtn.Click += logbtn_Click;
            // 
            // flashbtn
            // 
            flashbtn.BackColor = Color.Black;
            flashbtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flashbtn.ForeColor = SystemColors.ButtonFace;
            flashbtn.Location = new Point(370, 109);
            flashbtn.Name = "flashbtn";
            flashbtn.Size = new Size(274, 64);
            flashbtn.TabIndex = 3;
            flashbtn.Text = "FlashCard Manage";
            flashbtn.UseVisualStyleBackColor = false;
            flashbtn.Click += flashbtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(883, 406);
            Controls.Add(flashbtn);
            Controls.Add(logbtn);
            Controls.Add(userdetailsbtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label admin;
        private Button userdetailsbtn;
        private Button logbtn;
        private Button flashbtn;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}