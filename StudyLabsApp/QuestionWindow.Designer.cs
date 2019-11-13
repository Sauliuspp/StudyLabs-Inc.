namespace StudyLabsApp
{
    partial class QuestionWindow
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
            this.Discussion = new System.Windows.Forms.ListView();
            this.Nickname_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nickname = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.NicknameTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Discussion
            // 
            this.Discussion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nickname_header,
            this.Message_header});
            this.Discussion.HideSelection = false;
            this.Discussion.Location = new System.Drawing.Point(13, 13);
            this.Discussion.Name = "Discussion";
            this.Discussion.Size = new System.Drawing.Size(859, 375);
            this.Discussion.TabIndex = 0;
            this.Discussion.UseCompatibleStateImageBehavior = false;
            this.Discussion.View = System.Windows.Forms.View.Details;
            // 
            // Nickname_header
            // 
            this.Nickname_header.Text = "Nickname";
            this.Nickname_header.Width = 124;
            // 
            // Message_header
            // 
            this.Message_header.Text = "Message";
            this.Message_header.Width = 731;
            // 
            // Nickname
            // 
            this.Nickname.AutoSize = true;
            this.Nickname.Location = new System.Drawing.Point(13, 397);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(55, 13);
            this.Nickname.TabIndex = 1;
            this.Nickname.Text = "Nickname";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(152, 397);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(50, 13);
            this.Message.TabIndex = 2;
            this.Message.Text = "Message";
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.Location = new System.Drawing.Point(16, 420);
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(116, 20);
            this.NicknameTextBox.TabIndex = 3;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(155, 420);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(583, 20);
            this.MessageTextBox.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(744, 397);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(128, 52);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // QuestionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.NicknameTextBox);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.Discussion);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "QuestionWindow";
            this.Text = "QuestionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Discussion;
        private System.Windows.Forms.ColumnHeader Nickname_header;
        private System.Windows.Forms.ColumnHeader Message_header;
        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}