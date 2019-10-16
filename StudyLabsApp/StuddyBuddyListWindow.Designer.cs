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
            this.SuspendLayout();
            // 
            // StuddyBuddyList
            // 
            this.StuddyBuddyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nickname_header,
            this.fb_header,
            this.faculty_header,
            this.studies_header});
            this.StuddyBuddyList.HideSelection = false;
            this.StuddyBuddyList.Location = new System.Drawing.Point(12, 12);
            this.StuddyBuddyList.Name = "StuddyBuddyList";
            this.StuddyBuddyList.Size = new System.Drawing.Size(776, 426);
            this.StuddyBuddyList.TabIndex = 4;
            this.StuddyBuddyList.UseCompatibleStateImageBehavior = false;
            this.StuddyBuddyList.View = System.Windows.Forms.View.Details;
            this.StuddyBuddyList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nickname_header
            // 
            this.nickname_header.Text = "Nickname";
            this.nickname_header.Width = 142;
            // 
            // fb_header
            // 
            this.fb_header.Text = "Facebook";
            this.fb_header.Width = 166;
            // 
            // faculty_header
            // 
            this.faculty_header.Text = "Faculty";
            this.faculty_header.Width = 190;
            // 
            // studies_header
            // 
            this.studies_header.Text = "Studies";
            this.studies_header.Width = 157;
            // 
            // StuddyBuddyListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StuddyBuddyList);
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
    }
}