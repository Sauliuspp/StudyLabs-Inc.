namespace StudyLabsApp
{
    partial class Window
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
            this.MainMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EnterForums = new System.Windows.Forms.Button();
            this.FindStuddyBuddies = new System.Windows.Forms.Button();
            this.BecomeAStuddyBuddy = new System.Windows.Forms.Button();
            this.StuddyBuddy = new System.Windows.Forms.Label();
            this.PanelForUniversityList = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.StudiesComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.MainMenuPanel.SuspendLayout();
            this.PanelForUniversityList.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuPanel.ColumnCount = 1;
            this.MainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainMenuPanel.Controls.Add(this.EnterForums, 0, 0);
            this.MainMenuPanel.Controls.Add(this.FindStuddyBuddies, 0, 1);
            this.MainMenuPanel.Controls.Add(this.BecomeAStuddyBuddy, 0, 2);
            this.MainMenuPanel.Location = new System.Drawing.Point(12, 123);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.RowCount = 3;
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainMenuPanel.Size = new System.Drawing.Size(610, 426);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // EnterForums
            // 
            this.EnterForums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterForums.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.EnterForums.Location = new System.Drawing.Point(3, 3);
            this.EnterForums.Name = "EnterForums";
            this.EnterForums.Size = new System.Drawing.Size(604, 136);
            this.EnterForums.TabIndex = 0;
            this.EnterForums.Text = "Enter forums";
            this.EnterForums.UseVisualStyleBackColor = true;
            this.EnterForums.Click += new System.EventHandler(this.EnterForums_Click);
            // 
            // FindStuddyBuddies
            // 
            this.FindStuddyBuddies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindStuddyBuddies.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FindStuddyBuddies.Location = new System.Drawing.Point(3, 145);
            this.FindStuddyBuddies.Name = "FindStuddyBuddies";
            this.FindStuddyBuddies.Size = new System.Drawing.Size(604, 136);
            this.FindStuddyBuddies.TabIndex = 1;
            this.FindStuddyBuddies.Text = "Find StuddyBuddies";
            this.FindStuddyBuddies.UseVisualStyleBackColor = true;
            this.FindStuddyBuddies.Click += new System.EventHandler(this.FindStuddyBuddies_Click);
            // 
            // BecomeAStuddyBuddy
            // 
            this.BecomeAStuddyBuddy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BecomeAStuddyBuddy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BecomeAStuddyBuddy.Location = new System.Drawing.Point(3, 287);
            this.BecomeAStuddyBuddy.Name = "BecomeAStuddyBuddy";
            this.BecomeAStuddyBuddy.Size = new System.Drawing.Size(604, 136);
            this.BecomeAStuddyBuddy.TabIndex = 2;
            this.BecomeAStuddyBuddy.Text = "Become a StuddyBuddy";
            this.BecomeAStuddyBuddy.UseVisualStyleBackColor = true;
            this.BecomeAStuddyBuddy.Click += new System.EventHandler(this.BecomeAStuddyBuddy_Click);
            // 
            // StuddyBuddy
            // 
            this.StuddyBuddy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StuddyBuddy.BackColor = System.Drawing.SystemColors.Control;
            this.StuddyBuddy.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.StuddyBuddy.Location = new System.Drawing.Point(12, 9);
            this.StuddyBuddy.Name = "StuddyBuddy";
            this.StuddyBuddy.Size = new System.Drawing.Size(610, 111);
            this.StuddyBuddy.TabIndex = 1;
            this.StuddyBuddy.Text = "StuddyBuddy";
            this.StuddyBuddy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelForUniversityList
            // 
            this.PanelForUniversityList.Controls.Add(this.button1);
            this.PanelForUniversityList.Controls.Add(this.label3);
            this.PanelForUniversityList.Controls.Add(this.label2);
            this.PanelForUniversityList.Controls.Add(this.label1);
            this.PanelForUniversityList.Controls.Add(this.ReturnButton);
            this.PanelForUniversityList.Controls.Add(this.StudiesComboBox);
            this.PanelForUniversityList.Controls.Add(this.FacultyComboBox);
            this.PanelForUniversityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForUniversityList.Location = new System.Drawing.Point(0, 0);
            this.PanelForUniversityList.Name = "PanelForUniversityList";
            this.PanelForUniversityList.Size = new System.Drawing.Size(634, 561);
            this.PanelForUniversityList.TabIndex = 2;
            this.PanelForUniversityList.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search for StuddyBuddies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pick your desired studies: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pick your desired faculty: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick your studies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnButton.Location = new System.Drawing.Point(0, 492);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(634, 69);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return to Main Menu";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // StudiesComboBox
            // 
            this.StudiesComboBox.FormattingEnabled = true;
            this.StudiesComboBox.Location = new System.Drawing.Point(67, 295);
            this.StudiesComboBox.Name = "StudiesComboBox";
            this.StudiesComboBox.Size = new System.Drawing.Size(481, 21);
            this.StudiesComboBox.TabIndex = 1;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(67, 163);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(481, 21);
            this.FacultyComboBox.TabIndex = 0;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // Window
            // 
            this.AcceptButton = this.FindStuddyBuddies;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.PanelForUniversityList);
            this.Controls.Add(this.StuddyBuddy);
            this.Controls.Add(this.MainMenuPanel);
            this.MaximumSize = new System.Drawing.Size(650, 600);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Window";
            this.Text = "Studdy Buddy";
            this.MainMenuPanel.ResumeLayout(false);
            this.PanelForUniversityList.ResumeLayout(false);
            this.PanelForUniversityList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainMenuPanel;
        private System.Windows.Forms.Label StuddyBuddy;
        private System.Windows.Forms.Button EnterForums;
        private System.Windows.Forms.Button FindStuddyBuddies;
        private System.Windows.Forms.Panel PanelForUniversityList;
        private System.Windows.Forms.Button BecomeAStuddyBuddy;
        private System.Windows.Forms.ComboBox StudiesComboBox;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

