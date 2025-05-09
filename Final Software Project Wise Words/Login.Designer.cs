namespace Final_Software_Project_Wise_Words
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label5 = new Label();
            createlink = new LinkLabel();
            loginbtn = new Button();
            label3 = new Label();
            passtbx = new TextBox();
            label2 = new Label();
            usertbx = new TextBox();
            label1 = new Label();
            showpass = new CheckBox();
            pictureBox1 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(328, 496);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 23;
            label5.Text = "Don't have an Account?";
            // 
            // createlink
            // 
            createlink.Anchor = AnchorStyles.Right;
            createlink.AutoSize = true;
            createlink.Location = new Point(348, 528);
            createlink.Name = "createlink";
            createlink.Size = new Size(130, 20);
            createlink.TabIndex = 22;
            createlink.TabStop = true;
            createlink.Text = "Create an Account";
            createlink.LinkClicked += createlink_LinkClicked;
            // 
            // loginbtn
            // 
            loginbtn.Anchor = AnchorStyles.Right;
            loginbtn.BackColor = Color.LightSeaGreen;
            loginbtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(259, 403);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(286, 53);
            loginbtn.TabIndex = 21;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(259, 174);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 17;
            label3.Text = "Username:";
            // 
            // passtbx
            // 
            passtbx.Anchor = AnchorStyles.Right;
            passtbx.BackColor = SystemColors.InactiveCaption;
            passtbx.BorderStyle = BorderStyle.None;
            passtbx.Location = new Point(259, 302);
            passtbx.Multiline = true;
            passtbx.Name = "passtbx";
            passtbx.Size = new Size(286, 34);
            passtbx.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(259, 279);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 15;
            label2.Text = "Password:";
            // 
            // usertbx
            // 
            usertbx.Anchor = AnchorStyles.Right;
            usertbx.BackColor = SystemColors.InactiveCaption;
            usertbx.BorderStyle = BorderStyle.None;
            usertbx.Location = new Point(259, 197);
            usertbx.Multiline = true;
            usertbx.Name = "usertbx";
            usertbx.Size = new Size(286, 34);
            usertbx.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS UI Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(300, 79);
            label1.Name = "label1";
            label1.Size = new Size(238, 44);
            label1.TabIndex = 12;
            label1.Text = "Wise Words\r\n";
            // 
            // showpass
            // 
            showpass.Anchor = AnchorStyles.Right;
            showpass.AutoSize = true;
            showpass.Location = new Point(425, 341);
            showpass.Name = "showpass";
            showpass.Size = new Size(132, 24);
            showpass.TabIndex = 20;
            showpass.Text = "Show Password";
            showpass.UseVisualStyleBackColor = true;
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.Dock = DockStyle.Right;
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(425, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 25;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(564, 570);
            Controls.Add(nightControlBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(createlink);
            Controls.Add(loginbtn);
            Controls.Add(showpass);
            Controls.Add(label3);
            Controls.Add(passtbx);
            Controls.Add(label2);
            Controls.Add(usertbx);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(564, 570);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private LinkLabel createlink;
        private Button loginbtn;
        private Label label3;
        private TextBox passtbx;
        private Label label2;
        private TextBox usertbx;
        private Label label1;
        private CheckBox showpass;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}