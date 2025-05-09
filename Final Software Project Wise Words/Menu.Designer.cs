namespace Final_Software_Project_Wise_Words
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            menubtn = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sidebar = new FlowLayoutPanel();
            panel4 = new Panel();
            leaderbtn = new Button();
            panel5 = new Panel();
            historybtn = new Button();
            panel6 = new Panel();
            logoutbtn = new Button();
            learnbtn = new Button();
            quizbtn = new Button();
            diffbtn = new Button();
            randombtn = new Button();
            sidebartransition = new System.Windows.Forms.Timer(components);
            difselectlbl = new ReaLTaiizor.Controls.DungeonLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubtn).BeginInit();
            sidebar.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(menubtn);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 55);
            panel1.TabIndex = 0;
            // 
            // menubtn
            // 
            menubtn.Image = (Image)resources.GetObject("menubtn.Image");
            menubtn.Location = new Point(0, 12);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(37, 31);
            menubtn.SizeMode = PictureBoxSizeMode.StretchImage;
            menubtn.TabIndex = 1;
            menubtn.TabStop = false;
            menubtn.Click += menubtn_Click;
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
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.Black;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(761, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(428, 37);
            label1.TabIndex = 3;
            label1.Text = "Welcome To Wise Words";
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.Info;
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 55);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(51, 393);
            sidebar.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(leaderbtn);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 46);
            panel4.TabIndex = 7;
            // 
            // leaderbtn
            // 
            leaderbtn.BackColor = Color.Transparent;
            leaderbtn.FlatStyle = FlatStyle.Flat;
            leaderbtn.Font = new Font("MS UI Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leaderbtn.ForeColor = SystemColors.ActiveCaptionText;
            leaderbtn.Image = (Image)resources.GetObject("leaderbtn.Image");
            leaderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            leaderbtn.Location = new Point(-3, -3);
            leaderbtn.Name = "leaderbtn";
            leaderbtn.Size = new Size(226, 55);
            leaderbtn.TabIndex = 4;
            leaderbtn.Text = "Leaderboards";
            leaderbtn.UseVisualStyleBackColor = false;
            leaderbtn.Click += leaderbtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(historybtn);
            panel5.Location = new Point(3, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(223, 46);
            panel5.TabIndex = 9;
            // 
            // historybtn
            // 
            historybtn.BackColor = Color.Transparent;
            historybtn.FlatStyle = FlatStyle.Flat;
            historybtn.Font = new Font("MS UI Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historybtn.ForeColor = SystemColors.ActiveCaptionText;
            historybtn.Image = (Image)resources.GetObject("historybtn.Image");
            historybtn.ImageAlign = ContentAlignment.MiddleLeft;
            historybtn.Location = new Point(-3, -6);
            historybtn.Name = "historybtn";
            historybtn.Size = new Size(223, 63);
            historybtn.TabIndex = 4;
            historybtn.Text = "History";
            historybtn.UseVisualStyleBackColor = false;
            historybtn.Click += historybtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(logoutbtn);
            panel6.Location = new Point(3, 107);
            panel6.Name = "panel6";
            panel6.Size = new Size(223, 46);
            panel6.TabIndex = 11;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.Transparent;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("MS UI Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutbtn.ForeColor = SystemColors.ActiveCaptionText;
            logoutbtn.Image = (Image)resources.GetObject("logoutbtn.Image");
            logoutbtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutbtn.Location = new Point(-3, -15);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(223, 64);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // learnbtn
            // 
            learnbtn.Anchor = AnchorStyles.None;
            learnbtn.BackColor = Color.LightCoral;
            learnbtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            learnbtn.ForeColor = Color.White;
            learnbtn.Location = new Point(361, 90);
            learnbtn.Name = "learnbtn";
            learnbtn.Size = new Size(404, 50);
            learnbtn.TabIndex = 4;
            learnbtn.Text = "Learn";
            learnbtn.UseVisualStyleBackColor = false;
            learnbtn.Click += learnbtn_Click;
            // 
            // quizbtn
            // 
            quizbtn.Anchor = AnchorStyles.None;
            quizbtn.BackColor = Color.LightCoral;
            quizbtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizbtn.ForeColor = Color.White;
            quizbtn.Location = new Point(361, 169);
            quizbtn.Name = "quizbtn";
            quizbtn.Size = new Size(404, 50);
            quizbtn.TabIndex = 5;
            quizbtn.Text = "Quiz";
            quizbtn.UseVisualStyleBackColor = false;
            quizbtn.Click += quizbtn_Click;
            // 
            // diffbtn
            // 
            diffbtn.Anchor = AnchorStyles.None;
            diffbtn.BackColor = Color.LightCoral;
            diffbtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diffbtn.ForeColor = Color.White;
            diffbtn.Location = new Point(361, 246);
            diffbtn.Name = "diffbtn";
            diffbtn.Size = new Size(404, 50);
            diffbtn.TabIndex = 6;
            diffbtn.Text = "Difficulty";
            diffbtn.UseVisualStyleBackColor = false;
            diffbtn.Click += diffbtn_Click;
            // 
            // randombtn
            // 
            randombtn.Anchor = AnchorStyles.None;
            randombtn.BackColor = Color.LightCoral;
            randombtn.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            randombtn.ForeColor = Color.White;
            randombtn.Location = new Point(361, 324);
            randombtn.Name = "randombtn";
            randombtn.Size = new Size(404, 50);
            randombtn.TabIndex = 7;
            randombtn.Text = "Randomize";
            randombtn.UseVisualStyleBackColor = false;
            randombtn.Click += randombtn_Click;
            // 
            // sidebartransition
            // 
            sidebartransition.Interval = 10;
            sidebartransition.Tick += sidebartransition_Tick;
            // 
            // difselectlbl
            // 
            difselectlbl.Anchor = AnchorStyles.Bottom;
            difselectlbl.AutoSize = true;
            difselectlbl.BackColor = Color.Transparent;
            difselectlbl.Font = new Font("Segoe UI", 11F);
            difselectlbl.ForeColor = Color.FromArgb(76, 76, 77);
            difselectlbl.Location = new Point(361, 414);
            difselectlbl.Name = "difselectlbl";
            difselectlbl.Size = new Size(0, 25);
            difselectlbl.TabIndex = 8;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(900, 448);
            Controls.Add(difselectlbl);
            Controls.Add(randombtn);
            Controls.Add(diffbtn);
            Controls.Add(quizbtn);
            Controls.Add(learnbtn);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(900, 900);
            MinimumSize = new Size(639, 448);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubtn).EndInit();
            sidebar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel sidebar;
        private Panel panel4;
        private Button leaderbtn;
        private Panel panel5;
        private Button historybtn;
        private Label label1;
        private Button learnbtn;
        private Button quizbtn;
        private Button diffbtn;
        private Panel panel6;
        private Button logoutbtn;
        private Button randombtn;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox menubtn;
        private System.Windows.Forms.Timer sidebartransition;
        private ReaLTaiizor.Controls.DungeonLabel difselectlbl;
    }
}