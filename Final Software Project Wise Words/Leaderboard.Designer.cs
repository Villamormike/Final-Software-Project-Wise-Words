namespace Final_Software_Project_Wise_Words
{
    partial class Leaderboard
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
            refbtn = new ReaLTaiizor.Controls.Button();
            backbtn = new ReaLTaiizor.Controls.Button();
            leaderboardview = new ReaLTaiizor.Controls.MaterialListView();
            SuspendLayout();
            // 
            // refbtn
            // 
            refbtn.Anchor = AnchorStyles.Bottom;
            refbtn.BackColor = Color.Transparent;
            refbtn.BorderColor = Color.FromArgb(32, 34, 37);
            refbtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            refbtn.EnteredColor = Color.FromArgb(32, 34, 37);
            refbtn.Font = new Font("Microsoft Sans Serif", 12F);
            refbtn.Image = null;
            refbtn.ImageAlign = ContentAlignment.MiddleLeft;
            refbtn.InactiveColor = Color.FromArgb(32, 34, 37);
            refbtn.Location = new Point(613, 388);
            refbtn.Name = "refbtn";
            refbtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            refbtn.PressedColor = Color.FromArgb(165, 37, 37);
            refbtn.Size = new Size(150, 50);
            refbtn.TabIndex = 1;
            refbtn.Text = "Refresh";
            refbtn.TextAlignment = StringAlignment.Center;
            refbtn.Click += refbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Anchor = AnchorStyles.Bottom;
            backbtn.BackColor = Color.Transparent;
            backbtn.BorderColor = Color.FromArgb(32, 34, 37);
            backbtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            backbtn.EnteredColor = Color.FromArgb(32, 34, 37);
            backbtn.Font = new Font("Microsoft Sans Serif", 12F);
            backbtn.Image = null;
            backbtn.ImageAlign = ContentAlignment.MiddleLeft;
            backbtn.InactiveColor = Color.FromArgb(32, 34, 37);
            backbtn.Location = new Point(12, 388);
            backbtn.Name = "backbtn";
            backbtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            backbtn.PressedColor = Color.FromArgb(165, 37, 37);
            backbtn.Size = new Size(150, 50);
            backbtn.TabIndex = 2;
            backbtn.Text = "Back";
            backbtn.TextAlignment = StringAlignment.Center;
            backbtn.Click += backbtn_Click;
            // 
            // leaderboardview
            // 
            leaderboardview.AutoSizeTable = false;
            leaderboardview.BackColor = Color.FromArgb(255, 255, 255);
            leaderboardview.BorderStyle = BorderStyle.None;
            leaderboardview.Depth = 0;
            leaderboardview.Dock = DockStyle.Top;
            leaderboardview.ForeColor = Color.Black;
            leaderboardview.FullRowSelect = true;
            leaderboardview.Location = new Point(0, 0);
            leaderboardview.MinimumSize = new Size(200, 100);
            leaderboardview.MouseLocation = new Point(-1, -1);
            leaderboardview.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            leaderboardview.Name = "leaderboardview";
            leaderboardview.OwnerDraw = true;
            leaderboardview.Size = new Size(775, 382);
            leaderboardview.TabIndex = 3;
            leaderboardview.UseCompatibleStateImageBehavior = false;
            leaderboardview.View = View.Details;
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(775, 450);
            Controls.Add(leaderboardview);
            Controls.Add(backbtn);
            Controls.Add(refbtn);
            MaximizeBox = false;
            Name = "Leaderboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leaderboard";
            Load += Leaderboard_Load;
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button refbtn;
        private ReaLTaiizor.Controls.Button backbtn;
        private ReaLTaiizor.Controls.MaterialListView leaderboardview;
    }
}