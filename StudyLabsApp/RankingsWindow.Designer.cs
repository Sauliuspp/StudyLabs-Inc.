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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingsWindow));
            this.StuddyBuddyList = new System.Windows.Forms.ListView();
            this.Nickname_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FB_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Faculty_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Studies_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Points_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // StuddyBuddyList
            // 
            this.StuddyBuddyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nickname_header,
            this.FB_header,
            this.Faculty_header,
            this.Studies_header,
            this.Level_header,
            this.Points_header});
            resources.ApplyResources(this.StuddyBuddyList, "StuddyBuddyList");
            this.StuddyBuddyList.HideSelection = false;
            this.StuddyBuddyList.Name = "StuddyBuddyList";
            this.StuddyBuddyList.UseCompatibleStateImageBehavior = false;
            this.StuddyBuddyList.View = System.Windows.Forms.View.Details;
            this.StuddyBuddyList.SelectedIndexChanged += new System.EventHandler(this.StuddyBuddyList_SelectedIndexChanged);
            // 
            // Nickname_header
            // 
            resources.ApplyResources(this.Nickname_header, "Nickname_header");
            // 
            // FB_header
            // 
            resources.ApplyResources(this.FB_header, "FB_header");
            // 
            // Faculty_header
            // 
            resources.ApplyResources(this.Faculty_header, "Faculty_header");
            // 
            // Studies_header
            // 
            resources.ApplyResources(this.Studies_header, "Studies_header");
            // 
            // Level_header
            // 
            resources.ApplyResources(this.Level_header, "Level_header");
            // 
            // Points_header
            // 
            resources.ApplyResources(this.Points_header, "Points_header");
            // 
            // RankingsWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StuddyBuddyList);
            this.Name = "RankingsWindow";
            this.Load += new System.EventHandler(this.RankingsWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StuddyBuddyList;
        private System.Windows.Forms.ColumnHeader Nickname_header;
        private System.Windows.Forms.ColumnHeader FB_header;
        private System.Windows.Forms.ColumnHeader Faculty_header;
        private System.Windows.Forms.ColumnHeader Studies_header;
        private System.Windows.Forms.ColumnHeader Level_header;
        private System.Windows.Forms.ColumnHeader Points_header;
    }
}