using StudyLabsApp.DatabaseIO;
using StudyLabsApp.UserIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLabsApp
{
    public partial class QuestionWindow : Form
    {
        int QuestionId;

        public QuestionWindow(string id)
        {
            this.QuestionId = Int32.Parse(id);

            InitializeComponent();

            UIOutput output = new UIOutput();
            output.ShowFilteredDiscussion(Discussion, QuestionId);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Discussion.Items.Clear();
            string nickname = NicknameTextBox.Text;
            string message = MessageTextBox.Text;

            DatabaseProcessor processor = new DatabaseProcessor();
            processor.AddReplyToDiscussion(QuestionId, nickname, message);

            UIOutput output = new UIOutput();
            output.ShowFilteredDiscussion(Discussion, QuestionId);
        }
    }
}
