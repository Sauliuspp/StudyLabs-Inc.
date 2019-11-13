namespace StudyLabsApp
{
    partial class MainMenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuWindow));
            this.StuddyBuddy = new System.Windows.Forms.Label();
            this.PanelForUniversityList = new System.Windows.Forms.Panel();
            this.RankingsButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.StudiesComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.EnterForums = new System.Windows.Forms.Button();
            this.BecomeAStuddyBuddy = new System.Windows.Forms.Button();
            this.FindStuddyBuddies = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lForums = new System.Windows.Forms.Label();
            this.ComicBox = new System.Windows.Forms.PictureBox();
            this.PreviousImageButton = new System.Windows.Forms.Button();
            this.NextImageButton = new System.Windows.Forms.Button();
            this.PanelForUniversityList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StuddyBuddy
            // 
            this.StuddyBuddy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StuddyBuddy.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.StuddyBuddy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.StuddyBuddy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            //this.StuddyBuddy.Image = global::StudyLabsApp.Properties.Resources.StuddyBudyiconSMALL;
            this.StuddyBuddy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StuddyBuddy.Location = new System.Drawing.Point(0, 0);
            this.StuddyBuddy.Name = "StuddyBuddy";
            this.StuddyBuddy.Size = new System.Drawing.Size(169, 158);
            this.StuddyBuddy.TabIndex = 1;
            this.StuddyBuddy.Text = "StuddyBuddy";
            this.StuddyBuddy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PanelForUniversityList
            // 
            this.PanelForUniversityList.Controls.Add(this.RankingsButton);
            this.PanelForUniversityList.Controls.Add(this.SearchButton);
            this.PanelForUniversityList.Controls.Add(this.label3);
            this.PanelForUniversityList.Controls.Add(this.label2);
            this.PanelForUniversityList.Controls.Add(this.label1);
            this.PanelForUniversityList.Controls.Add(this.ReturnButton);
            this.PanelForUniversityList.Controls.Add(this.StudiesComboBox);
            this.PanelForUniversityList.Controls.Add(this.FacultyComboBox);
            this.PanelForUniversityList.Location = new System.Drawing.Point(169, 0);
            this.PanelForUniversityList.Name = "PanelForUniversityList";
            this.PanelForUniversityList.Size = new System.Drawing.Size(465, 563);
            this.PanelForUniversityList.TabIndex = 2;
            this.PanelForUniversityList.Visible = false;
            // 
            // RankingsButton
            // 
            this.RankingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(165)))), ((int)(((byte)(100)))));
            this.RankingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RankingsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankingsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RankingsButton.Location = new System.Drawing.Point(272, 402);
            this.RankingsButton.Name = "RankingsButton";
            this.RankingsButton.Size = new System.Drawing.Size(159, 70);
            this.RankingsButton.TabIndex = 7;
            this.RankingsButton.Text = "Find best StuddyBuddies for the faculty";
            this.RankingsButton.UseVisualStyleBackColor = false;
            this.RankingsButton.Click += new System.EventHandler(this.RankingsButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(165)))), ((int)(((byte)(100)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButton.Location = new System.Drawing.Point(30, 402);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(159, 70);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search for StuddyBuddies";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pick your desired studies: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pick your desired faculty: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick your studies";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(165)))), ((int)(((byte)(100)))));
            this.ReturnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnButton.Location = new System.Drawing.Point(0, 494);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(465, 69);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return to Main Menu";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // StudiesComboBox
            // 
            this.StudiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudiesComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudiesComboBox.FormattingEnabled = true;
            this.StudiesComboBox.Location = new System.Drawing.Point(30, 302);
            this.StudiesComboBox.Name = "StudiesComboBox";
            this.StudiesComboBox.Size = new System.Drawing.Size(401, 23);
            this.StudiesComboBox.TabIndex = 1;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(30, 184);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(401, 23);
            this.FacultyComboBox.TabIndex = 0;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // EnterForums
            // 
            this.EnterForums.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.EnterForums.Location = new System.Drawing.Point(7, 45);
            this.EnterForums.Name = "EnterForums";
            this.EnterForums.Size = new System.Drawing.Size(157, 103);
            this.EnterForums.TabIndex = 0;
            this.EnterForums.Text = "Enter forums";
            this.EnterForums.UseVisualStyleBackColor = true;
            this.EnterForums.Click += new System.EventHandler(this.EnterForums_Click);
            // 
            // BecomeAStuddyBuddy
            // 
            this.BecomeAStuddyBuddy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BecomeAStuddyBuddy.Location = new System.Drawing.Point(7, 263);
            this.BecomeAStuddyBuddy.Name = "BecomeAStuddyBuddy";
            this.BecomeAStuddyBuddy.Size = new System.Drawing.Size(157, 103);
            this.BecomeAStuddyBuddy.TabIndex = 2;
            this.BecomeAStuddyBuddy.Text = "Become a StuddyBuddy";
            this.BecomeAStuddyBuddy.UseVisualStyleBackColor = true;
            this.BecomeAStuddyBuddy.Click += new System.EventHandler(this.BecomeAStuddyBuddy_Click);
            // 
            // FindStuddyBuddies
            // 
            this.FindStuddyBuddies.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FindStuddyBuddies.Location = new System.Drawing.Point(7, 154);
            this.FindStuddyBuddies.Name = "FindStuddyBuddies";
            this.FindStuddyBuddies.Size = new System.Drawing.Size(157, 103);
            this.FindStuddyBuddies.TabIndex = 1;
            this.FindStuddyBuddies.Text = "Find Studdy Buddies";
            this.FindStuddyBuddies.UseVisualStyleBackColor = true;
            this.FindStuddyBuddies.Click += new System.EventHandler(this.FindStuddyBuddies_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.BecomeAStuddyBuddy);
            this.panel1.Controls.Add(this.FindStuddyBuddies);
            this.panel1.Controls.Add(this.EnterForums);
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 424);
            this.panel1.TabIndex = 3;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelLeft.Location = new System.Drawing.Point(160, 45);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 103);
            this.panelLeft.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(27, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "StudyLabs Inc.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lForums
            // 
            this.lForums.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForums.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lForums.Location = new System.Drawing.Point(254, 59);
            this.lForums.Name = "lForums";
            this.lForums.Size = new System.Drawing.Size(319, 127);
            this.lForums.TabIndex = 5;
            this.lForums.Text = "Not available in current version";
            // 
            // ComicBox
            // 
            this.ComicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComicBox.Location = new System.Drawing.Point(175, 163);
            this.ComicBox.Name = "ComicBox";
            this.ComicBox.Size = new System.Drawing.Size(450, 342);
            this.ComicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComicBox.TabIndex = 6;
            this.ComicBox.TabStop = false;
            // 
            // PreviousImageButton
            // 
            this.PreviousImageButton.Location = new System.Drawing.Point(178, 515);
            this.PreviousImageButton.Name = "PreviousImageButton";
            this.PreviousImageButton.Size = new System.Drawing.Size(220, 35);
            this.PreviousImageButton.TabIndex = 7;
            this.PreviousImageButton.Text = "Previous image";
            this.PreviousImageButton.UseVisualStyleBackColor = true;
            this.PreviousImageButton.Click += new System.EventHandler(this.PreviousImageButton_Click);
            // 
            // NextImageButton
            // 
            this.NextImageButton.Location = new System.Drawing.Point(401, 515);
            this.NextImageButton.Name = "NextImageButton";
            this.NextImageButton.Size = new System.Drawing.Size(220, 35);
            this.NextImageButton.TabIndex = 8;
            this.NextImageButton.Text = "Next image";
            this.NextImageButton.UseVisualStyleBackColor = true;
            this.NextImageButton.Click += new System.EventHandler(this.NextImageButton_Click);
            // 
            // MainMenuWindow
            // 
            this.AcceptButton = this.FindStuddyBuddies;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.PanelForUniversityList);
            this.Controls.Add(this.StuddyBuddy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lForums);
            this.Controls.Add(this.ComicBox);
            this.Controls.Add(this.PreviousImageButton);
            this.Controls.Add(this.NextImageButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 600);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "MainMenuWindow";
            this.Text = "Studdy Buddy";
            this.Load += new System.EventHandler(this.MainMenuWindow_Load);
            this.PanelForUniversityList.ResumeLayout(false);
            this.PanelForUniversityList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StuddyBuddy;
        private System.Windows.Forms.Panel PanelForUniversityList;
        private System.Windows.Forms.ComboBox StudiesComboBox;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RankingsButton;
        private System.Windows.Forms.Button EnterForums;
        private System.Windows.Forms.Button BecomeAStuddyBuddy;
        private System.Windows.Forms.Button FindStuddyBuddies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lForums;
        private System.Windows.Forms.PictureBox ComicBox;
        private System.Windows.Forms.Button PreviousImageButton;
        private System.Windows.Forms.Button NextImageButton;
    }
}

