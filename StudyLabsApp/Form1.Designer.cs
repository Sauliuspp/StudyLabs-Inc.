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
            this.StuddyBuddy = new System.Windows.Forms.Label();
            this.PanelForUniversityList = new System.Windows.Forms.Panel();
            this.UniversityList = new System.Windows.Forms.TableLayoutPanel();
            this.KaunasButton = new System.Windows.Forms.Button();
            this.PoliticalScienceButton = new System.Windows.Forms.Button();
            this.PhysicsButton = new System.Windows.Forms.Button();
            this.PhilosophyButton = new System.Windows.Forms.Button();
            this.PhilologyButton = new System.Windows.Forms.Button();
            this.MedicineButton = new System.Windows.Forms.Button();
            this.MathematicsInformaticsButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.EconomicsBusinessButton = new System.Windows.Forms.Button();
            this.LawButton = new System.Windows.Forms.Button();
            this.CommunicationButton = new System.Windows.Forms.Button();
            this.ChemistryGeosciencesButton = new System.Windows.Forms.Button();
            this.ReturnToMainMenuButton = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.PanelForUniversityList.SuspendLayout();
            this.UniversityList.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuPanel.ColumnCount = 1;
            this.MainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainMenuPanel.Controls.Add(this.EnterForums, 0, 0);
            this.MainMenuPanel.Controls.Add(this.FindStuddyBuddies, 0, 1);
            this.MainMenuPanel.Location = new System.Drawing.Point(12, 123);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.RowCount = 2;
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainMenuPanel.Size = new System.Drawing.Size(610, 426);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // EnterForums
            // 
            this.EnterForums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterForums.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.EnterForums.Location = new System.Drawing.Point(3, 3);
            this.EnterForums.Name = "EnterForums";
            this.EnterForums.Size = new System.Drawing.Size(604, 207);
            this.EnterForums.TabIndex = 0;
            this.EnterForums.Text = "Enter forums";
            this.EnterForums.UseVisualStyleBackColor = true;
            this.EnterForums.Click += new System.EventHandler(this.EnterForums_Click);
            // 
            // FindStuddyBuddies
            // 
            this.FindStuddyBuddies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindStuddyBuddies.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FindStuddyBuddies.Location = new System.Drawing.Point(3, 216);
            this.FindStuddyBuddies.Name = "FindStuddyBuddies";
            this.FindStuddyBuddies.Size = new System.Drawing.Size(604, 207);
            this.FindStuddyBuddies.TabIndex = 1;
            this.FindStuddyBuddies.Text = "Find studdy buddies";
            this.FindStuddyBuddies.UseVisualStyleBackColor = true;
            this.FindStuddyBuddies.Click += new System.EventHandler(this.FindStuddyBuddies_Click);
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
            this.StuddyBuddy.Text = "Studdy buddy";
            this.StuddyBuddy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelForUniversityList
            // 
            this.PanelForUniversityList.Controls.Add(this.UniversityList);
            this.PanelForUniversityList.Controls.Add(this.ReturnToMainMenuButton);
            this.PanelForUniversityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForUniversityList.Location = new System.Drawing.Point(0, 0);
            this.PanelForUniversityList.Name = "PanelForUniversityList";
            this.PanelForUniversityList.Size = new System.Drawing.Size(634, 561);
            this.PanelForUniversityList.TabIndex = 2;
            this.PanelForUniversityList.Visible = false;
            // 
            // UniversityList
            // 
            this.UniversityList.ColumnCount = 3;
            this.UniversityList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.UniversityList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.UniversityList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.UniversityList.Controls.Add(this.KaunasButton, 2, 3);
            this.UniversityList.Controls.Add(this.PoliticalScienceButton, 1, 3);
            this.UniversityList.Controls.Add(this.PhysicsButton, 0, 3);
            this.UniversityList.Controls.Add(this.PhilosophyButton, 2, 2);
            this.UniversityList.Controls.Add(this.PhilologyButton, 1, 2);
            this.UniversityList.Controls.Add(this.MedicineButton, 0, 2);
            this.UniversityList.Controls.Add(this.MathematicsInformaticsButton, 2, 1);
            this.UniversityList.Controls.Add(this.HistoryButton, 1, 1);
            this.UniversityList.Controls.Add(this.EconomicsBusinessButton, 0, 1);
            this.UniversityList.Controls.Add(this.LawButton, 2, 0);
            this.UniversityList.Controls.Add(this.CommunicationButton, 1, 0);
            this.UniversityList.Controls.Add(this.ChemistryGeosciencesButton, 0, 0);
            this.UniversityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UniversityList.Location = new System.Drawing.Point(0, 0);
            this.UniversityList.Name = "UniversityList";
            this.UniversityList.RowCount = 4;
            this.UniversityList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UniversityList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UniversityList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UniversityList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UniversityList.Size = new System.Drawing.Size(634, 485);
            this.UniversityList.TabIndex = 1;
            // 
            // KaunasButton
            // 
            this.KaunasButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KaunasButton.Location = new System.Drawing.Point(425, 366);
            this.KaunasButton.Name = "KaunasButton";
            this.KaunasButton.Size = new System.Drawing.Size(206, 116);
            this.KaunasButton.TabIndex = 12;
            this.KaunasButton.Text = "Kaunas Faculty";
            this.KaunasButton.UseVisualStyleBackColor = true;
            // 
            // PoliticalScienceButton
            // 
            this.PoliticalScienceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoliticalScienceButton.Location = new System.Drawing.Point(214, 366);
            this.PoliticalScienceButton.Name = "PoliticalScienceButton";
            this.PoliticalScienceButton.Size = new System.Drawing.Size(205, 116);
            this.PoliticalScienceButton.TabIndex = 11;
            this.PoliticalScienceButton.Text = "Institute of International Relations and Political Science";
            this.PoliticalScienceButton.UseVisualStyleBackColor = true;
            // 
            // PhysicsButton
            // 
            this.PhysicsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhysicsButton.Location = new System.Drawing.Point(3, 366);
            this.PhysicsButton.Name = "PhysicsButton";
            this.PhysicsButton.Size = new System.Drawing.Size(205, 116);
            this.PhysicsButton.TabIndex = 10;
            this.PhysicsButton.Text = "Faculty of Physics";
            this.PhysicsButton.UseVisualStyleBackColor = true;
            // 
            // PhilosophyButton
            // 
            this.PhilosophyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhilosophyButton.Location = new System.Drawing.Point(425, 245);
            this.PhilosophyButton.Name = "PhilosophyButton";
            this.PhilosophyButton.Size = new System.Drawing.Size(206, 115);
            this.PhilosophyButton.TabIndex = 9;
            this.PhilosophyButton.Text = "Faculty of Philosophy";
            this.PhilosophyButton.UseVisualStyleBackColor = true;
            // 
            // PhilologyButton
            // 
            this.PhilologyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhilologyButton.Location = new System.Drawing.Point(214, 245);
            this.PhilologyButton.Name = "PhilologyButton";
            this.PhilologyButton.Size = new System.Drawing.Size(205, 115);
            this.PhilologyButton.TabIndex = 8;
            this.PhilologyButton.Text = "Faculty of Philology";
            this.PhilologyButton.UseVisualStyleBackColor = true;
            // 
            // MedicineButton
            // 
            this.MedicineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicineButton.Location = new System.Drawing.Point(3, 245);
            this.MedicineButton.Name = "MedicineButton";
            this.MedicineButton.Size = new System.Drawing.Size(205, 115);
            this.MedicineButton.TabIndex = 7;
            this.MedicineButton.Text = "Faculty of Medicine";
            this.MedicineButton.UseVisualStyleBackColor = true;
            // 
            // MathematicsInformaticsButton
            // 
            this.MathematicsInformaticsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MathematicsInformaticsButton.Location = new System.Drawing.Point(425, 124);
            this.MathematicsInformaticsButton.Name = "MathematicsInformaticsButton";
            this.MathematicsInformaticsButton.Size = new System.Drawing.Size(206, 115);
            this.MathematicsInformaticsButton.TabIndex = 6;
            this.MathematicsInformaticsButton.Text = "Faculty of Mathematics and Informatics";
            this.MathematicsInformaticsButton.UseVisualStyleBackColor = true;
            // 
            // HistoryButton
            // 
            this.HistoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryButton.Location = new System.Drawing.Point(214, 124);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(205, 115);
            this.HistoryButton.TabIndex = 5;
            this.HistoryButton.Text = "Faculty of History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            // 
            // EconomicsBusinessButton
            // 
            this.EconomicsBusinessButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EconomicsBusinessButton.Location = new System.Drawing.Point(3, 124);
            this.EconomicsBusinessButton.Name = "EconomicsBusinessButton";
            this.EconomicsBusinessButton.Size = new System.Drawing.Size(205, 115);
            this.EconomicsBusinessButton.TabIndex = 4;
            this.EconomicsBusinessButton.Text = "Faculty of Economics and Business Administration";
            this.EconomicsBusinessButton.UseVisualStyleBackColor = true;
            // 
            // LawButton
            // 
            this.LawButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LawButton.Location = new System.Drawing.Point(425, 3);
            this.LawButton.Name = "LawButton";
            this.LawButton.Size = new System.Drawing.Size(206, 115);
            this.LawButton.TabIndex = 3;
            this.LawButton.Text = "Faculty of Law";
            this.LawButton.UseVisualStyleBackColor = true;
            // 
            // CommunicationButton
            // 
            this.CommunicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommunicationButton.Location = new System.Drawing.Point(214, 3);
            this.CommunicationButton.Name = "CommunicationButton";
            this.CommunicationButton.Size = new System.Drawing.Size(205, 115);
            this.CommunicationButton.TabIndex = 2;
            this.CommunicationButton.Text = "Faculty of Communication";
            this.CommunicationButton.UseVisualStyleBackColor = true;
            // 
            // ChemistryGeosciencesButton
            // 
            this.ChemistryGeosciencesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChemistryGeosciencesButton.Location = new System.Drawing.Point(3, 3);
            this.ChemistryGeosciencesButton.Name = "ChemistryGeosciencesButton";
            this.ChemistryGeosciencesButton.Size = new System.Drawing.Size(205, 115);
            this.ChemistryGeosciencesButton.TabIndex = 1;
            this.ChemistryGeosciencesButton.Text = "Faculty of Chemistry and Geosciences";
            this.ChemistryGeosciencesButton.UseVisualStyleBackColor = true;
            this.ChemistryGeosciencesButton.Click += new System.EventHandler(this.ChemistryGeosciencesButton_Click);
            // 
            // ReturnToMainMenuButton
            // 
            this.ReturnToMainMenuButton.AutoSize = true;
            this.ReturnToMainMenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReturnToMainMenuButton.Location = new System.Drawing.Point(0, 485);
            this.ReturnToMainMenuButton.Name = "ReturnToMainMenuButton";
            this.ReturnToMainMenuButton.Size = new System.Drawing.Size(634, 76);
            this.ReturnToMainMenuButton.TabIndex = 0;
            this.ReturnToMainMenuButton.Text = "Return To Main Menu";
            this.ReturnToMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMainMenuButton.Click += new System.EventHandler(this.ReturnToMainMenuButton_Click);
            // 
            // Window2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.PanelForUniversityList);
            this.Controls.Add(this.StuddyBuddy);
            this.Controls.Add(this.MainMenuPanel);
            this.MaximumSize = new System.Drawing.Size(650, 600);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Window2";
            this.Text = "Studdy Buddy";
            this.MainMenuPanel.ResumeLayout(false);
            this.PanelForUniversityList.ResumeLayout(false);
            this.PanelForUniversityList.PerformLayout();
            this.UniversityList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainMenuPanel;
        private System.Windows.Forms.Label StuddyBuddy;
        private System.Windows.Forms.Button EnterForums;
        private System.Windows.Forms.Button FindStuddyBuddies;
        private System.Windows.Forms.Panel PanelForUniversityList;
        private System.Windows.Forms.Button ReturnToMainMenuButton;
        private System.Windows.Forms.TableLayoutPanel UniversityList;
        private System.Windows.Forms.Button KaunasButton;
        private System.Windows.Forms.Button PoliticalScienceButton;
        private System.Windows.Forms.Button PhysicsButton;
        private System.Windows.Forms.Button PhilosophyButton;
        private System.Windows.Forms.Button PhilologyButton;
        private System.Windows.Forms.Button MedicineButton;
        private System.Windows.Forms.Button MathematicsInformaticsButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button EconomicsBusinessButton;
        private System.Windows.Forms.Button LawButton;
        private System.Windows.Forms.Button CommunicationButton;
        private System.Windows.Forms.Button ChemistryGeosciencesButton;
    }
}

