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
        string SelectedFaculty;
        string SelectedStudies;
        public QuestionWindow(string id, string faculty, string studies)
        {
            this.QuestionId = Int32.Parse(id);
            this.SelectedFaculty = faculty;
            this.SelectedStudies = studies;

            InitializeComponent();

            UIOutput output = new UIOutput();
            output.ShowFilteredDiscussion(Discussion, QuestionId, SelectedFaculty, SelectedStudies);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
