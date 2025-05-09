namespace Final_Software_Project_Wise_Words
{
    partial class History
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
            hisview = new ReaLTaiizor.Controls.MaterialListView();
            SuspendLayout();
            // 
            // hisview
            // 
            hisview.AutoSizeTable = false;
            hisview.BackColor = Color.FromArgb(255, 255, 255);
            hisview.BorderStyle = BorderStyle.None;
            hisview.Depth = 0;
            hisview.Dock = DockStyle.Fill;
            hisview.FullRowSelect = true;
            hisview.Location = new Point(0, 0);
            hisview.MinimumSize = new Size(200, 100);
            hisview.MouseLocation = new Point(-1, -1);
            hisview.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            hisview.Name = "hisview";
            hisview.OwnerDraw = true;
            hisview.Size = new Size(800, 450);
            hisview.TabIndex = 1;
            hisview.UseCompatibleStateImageBehavior = false;
            hisview.View = View.Details;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hisview);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialListView hisview;
    }
}