namespace StudyLabsApp
{
    partial class RankingsWindow
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
            this.StuddyBuddyList = new System.Windows.Forms.ListView();
            this.Nickname_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FB_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Faculty_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Studies_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // StuddyBuddyList
            // 
            this.StuddyBuddyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nickname_header,
            this.FB_header,
            this.Faculty_header,
            this.Studies_header,
            this.Level_header});
            this.StuddyBuddyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuddyBuddyList.HideSelection = false;
            this.StuddyBuddyList.Location = new System.Drawing.Point(0, 0);
            this.StuddyBuddyList.Name = "StuddyBuddyList";
            this.StuddyBuddyList.Size = new System.Drawing.Size(834, 511);
            this.StuddyBuddyList.TabIndex = 5;
            this.StuddyBuddyList.UseCompatibleStateImageBehavior = false;
            this.StuddyBuddyList.View = System.Windows.Forms.View.Details;
            // 
            // Nickname_header
            // 
            this.Nickname_header.Text = "Nickname";
            this.Nickname_header.Width = 164;
            // 
            // FB_header
            // 
            this.FB_header.Text = "Facebook";
            this.FB_header.Width = 179;
            // 
            // Faculty_header
            // 
            this.Faculty_header.Text = "Faculty";
            this.Faculty_header.Width = 172;
            // 
            // Studies_header
            // 
            this.Studies_header.Text = "Studies";
            this.Studies_header.Width = 167;
            // 
            // Level_header
            // 
            this.Level_header.Text = "Level";
            this.Level_header.Width = 147;
            // 
            // RankingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.StuddyBuddyList);
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "RankingsWindow";
            this.Text = "RankingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StuddyBuddyList;
        private System.Windows.Forms.ColumnHeader Nickname_header;
        private System.Windows.Forms.ColumnHeader FB_header;
        private System.Windows.Forms.ColumnHeader Faculty_header;
        private System.Windows.Forms.ColumnHeader Studies_header;
        private System.Windows.Forms.ColumnHeader Level_header;
    }
}