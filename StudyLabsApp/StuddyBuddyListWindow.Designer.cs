namespace StudyLabsApp
{
    partial class StuddyBuddyListWindow
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
            this.nickname_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fb_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.faculty_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studies_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // StuddyBuddyList
            // 
            this.StuddyBuddyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nickname_header,
            this.fb_header,
            this.faculty_header,
            this.studies_header,
            this.Level_header});
            this.StuddyBuddyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuddyBuddyList.HideSelection = false;
            this.StuddyBuddyList.Location = new System.Drawing.Point(0, 0);
            this.StuddyBuddyList.Name = "StuddyBuddyList";
            this.StuddyBuddyList.Size = new System.Drawing.Size(834, 511);
            this.StuddyBuddyList.TabIndex = 4;
            this.StuddyBuddyList.UseCompatibleStateImageBehavior = false;
            this.StuddyBuddyList.View = System.Windows.Forms.View.Details;
            // 
            // nickname_header
            // 
            this.nickname_header.Text = "Nickname";
            this.nickname_header.Width = 164;
            // 
            // fb_header
            // 
            this.fb_header.Text = "Facebook";
            this.fb_header.Width = 179;
            // 
            // faculty_header
            // 
            this.faculty_header.Text = "Faculty";
            this.faculty_header.Width = 172;
            // 
            // studies_header
            // 
            this.studies_header.Text = "Studies";
            this.studies_header.Width = 167;
            // 
            // Level_header
            // 
            this.Level_header.Text = "Level";
            this.Level_header.Width = 147;
            // 
            // StuddyBuddyListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.StuddyBuddyList);
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "StuddyBuddyListWindow";
            this.Text = "Buddy list";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView StuddyBuddyList;
        private System.Windows.Forms.ColumnHeader nickname_header;
        private System.Windows.Forms.ColumnHeader fb_header;
        private System.Windows.Forms.ColumnHeader faculty_header;
        private System.Windows.Forms.ColumnHeader studies_header;
        private System.Windows.Forms.ColumnHeader Level_header;
    }
}