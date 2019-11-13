namespace StudyLabsApp
{
    partial class ForumsWindow
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
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.StudiesComboBox = new System.Windows.Forms.ComboBox();
            this.QuestionList = new System.Windows.Forms.ListView();
            this.Question_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.DropDownWidth = 310;
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(7, 7);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(306, 21);
            this.FacultyComboBox.TabIndex = 0;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // StudiesComboBox
            // 
            this.StudiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudiesComboBox.DropDownWidth = 310;
            this.StudiesComboBox.FormattingEnabled = true;
            this.StudiesComboBox.Location = new System.Drawing.Point(319, 7);
            this.StudiesComboBox.Name = "StudiesComboBox";
            this.StudiesComboBox.Size = new System.Drawing.Size(303, 21);
            this.StudiesComboBox.TabIndex = 1;
            this.StudiesComboBox.SelectedIndexChanged += new System.EventHandler(this.StudiesComboBox_SelectedIndexChanged);
            // 
            // QuestionList
            // 
            this.QuestionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Question_header,
            this.Author_header,
            this.Date_header,
            this.Id_header});
            this.QuestionList.FullRowSelect = true;
            this.QuestionList.HideSelection = false;
            this.QuestionList.Location = new System.Drawing.Point(12, 34);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(610, 515);
            this.QuestionList.TabIndex = 2;
            this.QuestionList.UseCompatibleStateImageBehavior = false;
            this.QuestionList.View = System.Windows.Forms.View.Details;
            this.QuestionList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.QuestionList_MouseDoubleClick);
            // 
            // Question_header
            // 
            this.Question_header.Text = "Question";
            this.Question_header.Width = 329;
            // 
            // Author_header
            // 
            this.Author_header.Text = "Nickname";
            this.Author_header.Width = 160;
            // 
            // Date_header
            // 
            this.Date_header.Text = "Date";
            this.Date_header.Width = 117;
            // 
            // Id_header
            // 
            this.Id_header.Text = "Id";
            this.Id_header.Width = 0;
            // 
            // ForumsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.QuestionList);
            this.Controls.Add(this.StudiesComboBox);
            this.Controls.Add(this.FacultyComboBox);
            this.MaximumSize = new System.Drawing.Size(650, 600);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ForumsWindow";
            this.Text = "Studdy Buddy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.ComboBox StudiesComboBox;
        private System.Windows.Forms.ListView QuestionList;
        private System.Windows.Forms.ColumnHeader Question_header;
        private System.Windows.Forms.ColumnHeader Author_header;
        private System.Windows.Forms.ColumnHeader Date_header;
        private System.Windows.Forms.ColumnHeader Id_header;
    }
}