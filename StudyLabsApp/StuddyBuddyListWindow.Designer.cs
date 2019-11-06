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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuddyBuddyListWindow));
            this.StuddyBuddyList = new System.Windows.Forms.ListView();
            this.nickname_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fb_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.faculty_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studies_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Points_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // StuddyBuddyList
            // 
            this.StuddyBuddyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.StuddyBuddyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nickname_header,
            this.fb_header,
            this.faculty_header,
            this.studies_header,
            this.Status_header,
            this.Points_header});
            this.StuddyBuddyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuddyBuddyList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuddyBuddyList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StuddyBuddyList.HideSelection = false;
            this.StuddyBuddyList.Location = new System.Drawing.Point(0, 0);
            this.StuddyBuddyList.Name = "StuddyBuddyList";
            this.StuddyBuddyList.Size = new System.Drawing.Size(984, 511);
            this.StuddyBuddyList.TabIndex = 4;
            this.StuddyBuddyList.UseCompatibleStateImageBehavior = false;
            this.StuddyBuddyList.View = System.Windows.Forms.View.Details;
            this.StuddyBuddyList.SelectedIndexChanged += new System.EventHandler(this.StuddyBuddyList_SelectedIndexChanged);
            // 
            // nickname_header
            // 
            this.nickname_header.Text = "Nickname";
            this.nickname_header.Width = 178;
            // 
            // fb_header
            // 
            this.fb_header.Text = "Facebook";
            this.fb_header.Width = 193;
            // 
            // faculty_header
            // 
            this.faculty_header.Text = "Faculty";
            this.faculty_header.Width = 154;
            // 
            // studies_header
            // 
            this.studies_header.Text = "Studies";
            this.studies_header.Width = 273;
            // 
            // Status_header
            // 
            this.Status_header.Text = "Level";
            this.Status_header.Width = 93;
            // 
            // Points_header
            // 
            this.Points_header.Text = "Points";
            this.Points_header.Width = 88;
            // 
            // StuddyBuddyListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.StuddyBuddyList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 550);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
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
        private System.Windows.Forms.ColumnHeader Status_header;
        private System.Windows.Forms.ColumnHeader Points_header;
    }
}