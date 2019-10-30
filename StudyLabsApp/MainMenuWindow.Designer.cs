﻿namespace StudyLabsApp
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
            this.EnterForums = new System.Windows.Forms.Button();
            this.FindStuddyBuddies = new System.Windows.Forms.Button();
            this.BecomeAStuddyBuddy = new System.Windows.Forms.Button();
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
            this.lForums = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelForUniversityList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterForums
            // 
            this.EnterForums.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.EnterForums.Location = new System.Drawing.Point(6, 178);
            this.EnterForums.Name = "EnterForums";
            this.EnterForums.Size = new System.Drawing.Size(157, 103);
            this.EnterForums.TabIndex = 0;
            this.EnterForums.Text = "Enter forums";
            this.EnterForums.UseVisualStyleBackColor = true;
            this.EnterForums.Click += new System.EventHandler(this.EnterForums_Click);
            // 
            // FindStuddyBuddies
            // 
            this.FindStuddyBuddies.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FindStuddyBuddies.Location = new System.Drawing.Point(6, 287);
            this.FindStuddyBuddies.Name = "FindStuddyBuddies";
            this.FindStuddyBuddies.Size = new System.Drawing.Size(157, 103);
            this.FindStuddyBuddies.TabIndex = 1;
            this.FindStuddyBuddies.Text = "Find Studdy Buddies";
            this.FindStuddyBuddies.UseVisualStyleBackColor = true;
            this.FindStuddyBuddies.Click += new System.EventHandler(this.FindStuddyBuddies_Click);
            // 
            // BecomeAStuddyBuddy
            // 
            this.BecomeAStuddyBuddy.FlatAppearance.BorderSize = 0;
            this.BecomeAStuddyBuddy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BecomeAStuddyBuddy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BecomeAStuddyBuddy.Location = new System.Drawing.Point(6, 396);
            this.BecomeAStuddyBuddy.Name = "BecomeAStuddyBuddy";
            this.BecomeAStuddyBuddy.Size = new System.Drawing.Size(157, 105);
            this.BecomeAStuddyBuddy.TabIndex = 2;
            this.BecomeAStuddyBuddy.Text = "Become a StuddyBuddy";
            this.BecomeAStuddyBuddy.UseVisualStyleBackColor = true;
            this.BecomeAStuddyBuddy.Click += new System.EventHandler(this.BecomeAStuddyBuddy_Click);
            // 
            // StuddyBuddy
            // 
            this.StuddyBuddy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StuddyBuddy.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.StuddyBuddy.Font = new System.Drawing.Font("standard 07_57", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuddyBuddy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StuddyBuddy.Image = ((System.Drawing.Image)(resources.GetObject("StuddyBuddy.Image")));
            this.StuddyBuddy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StuddyBuddy.Location = new System.Drawing.Point(0, 0);
            this.StuddyBuddy.Name = "StuddyBuddy";
            this.StuddyBuddy.Size = new System.Drawing.Size(166, 151);
            this.StuddyBuddy.TabIndex = 1;
            this.StuddyBuddy.Text = "StuddyBuddy";
            this.StuddyBuddy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StuddyBuddy.Click += new System.EventHandler(this.StuddyBuddy_Click);
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
            this.PanelForUniversityList.Location = new System.Drawing.Point(172, 0);
            this.PanelForUniversityList.Name = "PanelForUniversityList";
            this.PanelForUniversityList.Size = new System.Drawing.Size(462, 561);
            this.PanelForUniversityList.TabIndex = 2;
            this.PanelForUniversityList.Visible = false;
            this.PanelForUniversityList.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelForUniversityList_Paint);
            // 
            // RankingsButton
            // 
            this.RankingsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankingsButton.Location = new System.Drawing.Point(284, 396);
            this.RankingsButton.Name = "RankingsButton";
            this.RankingsButton.Size = new System.Drawing.Size(159, 70);
            this.RankingsButton.TabIndex = 7;
            this.RankingsButton.Text = "Find best StuddyBuddies for the faculty";
            this.RankingsButton.UseVisualStyleBackColor = true;
            this.RankingsButton.Click += new System.EventHandler(this.RankingsButton_Click_1);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(26, 396);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(159, 70);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search for StuddyBuddies";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(23, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pick your desired studies: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pick your desired faculty: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick your studies";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnButton.Location = new System.Drawing.Point(0, 492);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(462, 69);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return to Main Menu";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // StudiesComboBox
            // 
            this.StudiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudiesComboBox.FormattingEnabled = true;
            this.StudiesComboBox.Location = new System.Drawing.Point(26, 300);
            this.StudiesComboBox.Name = "StudiesComboBox";
            this.StudiesComboBox.Size = new System.Drawing.Size(417, 21);
            this.StudiesComboBox.TabIndex = 1;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(26, 173);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(417, 21);
            this.FacultyComboBox.TabIndex = 0;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // lForums
            // 
            this.lForums.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForums.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lForums.Location = new System.Drawing.Point(204, 41);
            this.lForums.Name = "lForums";
            this.lForums.Size = new System.Drawing.Size(412, 89);
            this.lForums.TabIndex = 8;
            this.lForums.Text = "Not available in current version";
            this.lForums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lForums.Click += new System.EventHandler(this.lForums_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EnterForums);
            this.panel1.Controls.Add(this.StuddyBuddy);
            this.panel1.Controls.Add(this.FindStuddyBuddies);
            this.panel1.Controls.Add(this.BecomeAStuddyBuddy);
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 561);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(25, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "StudyLabs Inc.";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelLeft.ForeColor = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(156, 178);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 103);
            this.panelLeft.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label5.Location = new System.Drawing.Point(298, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 300);
            this.label5.TabIndex = 9;
            this.label5.Text = " ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 419);
            this.panel2.TabIndex = 6;
            // 
            // MainMenuWindow
            // 
            this.AcceptButton = this.FindStuddyBuddies;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelForUniversityList);
            this.Controls.Add(this.lForums);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 600);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainMenuWindow";
            this.Text = "Studdy Buddy";
            this.Load += new System.EventHandler(this.MainMenuWindow_Load);
            this.PanelForUniversityList.ResumeLayout(false);
            this.PanelForUniversityList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RankingsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lForums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}

