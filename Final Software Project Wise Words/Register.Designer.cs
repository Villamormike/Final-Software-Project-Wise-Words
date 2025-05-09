namespace Final_Software_Project_Wise_Words
{
    partial class register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            label1 = new Label();
            usertbx = new TextBox();
            label2 = new Label();
            passtbx = new TextBox();
            label3 = new Label();
            confirmpasstbx = new TextBox();
            label4 = new Label();
            showpass = new CheckBox();
            regbtn = new Button();
            linklogin = new LinkLabel();
            label5 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(292, 50);
            label1.Name = "label1";
            label1.Size = new Size(246, 44);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // usertbx
            // 
            usertbx.Anchor = AnchorStyles.Right;
            usertbx.BackColor = SystemColors.InactiveCaption;
            usertbx.BorderStyle = BorderStyle.None;
            usertbx.Location = new Point(248, 143);
            usertbx.Multiline = true;
            usertbx.Name = "usertbx";
            usertbx.Size = new Size(304, 34);
            usertbx.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(248, 203);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // passtbx
            // 
            passtbx.Anchor = AnchorStyles.Right;
            passtbx.BackColor = SystemColors.InactiveCaption;
            passtbx.BorderStyle = BorderStyle.None;
            passtbx.Location = new Point(248, 226);
            passtbx.Multiline = true;
            passtbx.Name = "passtbx";
            passtbx.Size = new Size(304, 34);
            passtbx.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(248, 120);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            // 
            // confirmpasstbx
            // 
            confirmpasstbx.Anchor = AnchorStyles.Right;
            confirmpasstbx.BackColor = SystemColors.InactiveCaption;
            confirmpasstbx.BorderStyle = BorderStyle.None;
            confirmpasstbx.Location = new Point(248, 324);
            confirmpasstbx.Multiline = true;
            confirmpasstbx.Name = "confirmpasstbx";
            confirmpasstbx.Size = new Size(304, 34);
            confirmpasstbx.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(248, 301);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password:";
            // 
            // showpass
            // 
            showpass.Anchor = AnchorStyles.Right;
            showpass.AutoSize = true;
            showpass.Location = new Point(420, 364);
            showpass.Name = "showpass";
            showpass.Size = new Size(132, 24);
            showpass.TabIndex = 8;
            showpass.Text = "Show Password";
            showpass.UseVisualStyleBackColor = true;
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // regbtn
            // 
            regbtn.Anchor = AnchorStyles.Right;
            regbtn.BackColor = Color.LightSeaGreen;
            regbtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regbtn.ForeColor = Color.White;
            regbtn.Location = new Point(248, 412);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(304, 53);
            regbtn.TabIndex = 9;
            regbtn.Text = "Register";
            regbtn.UseVisualStyleBackColor = false;
            regbtn.Click += regbtn_Click;
            // 
            // linklogin
            // 
            linklogin.Anchor = AnchorStyles.Right;
            linklogin.AutoSize = true;
            linklogin.Location = new Point(344, 528);
            linklogin.Name = "linklogin";
            linklogin.Size = new Size(111, 20);
            linklogin.TabIndex = 10;
            linklogin.TabStop = true;
            linklogin.Text = "Login Acccount";
            linklogin.LinkClicked += linklogin_LinkClicked;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(317, 496);
            label5.Name = "label5";
            label5.Size = new Size(180, 20);
            label5.TabIndex = 11;
            label5.Text = "Already have an Account?";
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
            nightControlBox1.Location = new Point(416, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(564, 570);
            Controls.Add(pictureBox1);
            Controls.Add(nightControlBox1);
            Controls.Add(label5);
            Controls.Add(linklogin);
            Controls.Add(regbtn);
            Controls.Add(showpass);
            Controls.Add(confirmpasstbx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passtbx);
            Controls.Add(label2);
            Controls.Add(usertbx);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(564, 570);
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usertbx;
        private Label label2;
        private TextBox passtbx;
        private Label label3;
        private TextBox confirmpasstbx;
        private Label label4;
        private CheckBox showpass;
        private Button regbtn;
        private LinkLabel linklogin;
        private Label label5;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox pictureBox1;
    }
}
