using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using StudyLabsApp.Properties;
using StudyLabsApp.UserIO;
using StudyLabsApp.DatabaseIO;

namespace StudyLabsApp
{
    public partial class ForumsWindow : Form
    {
        public ForumsWindow()
        {
            InitializeComponent();

            UIOutput output = new UIOutput();
            output.ShowFaculties(FacultyComboBox);
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudiesComboBox.Items.Clear();
            FacultyComboBox.SelectedItem = "";

            UIOutput output = new UIOutput();
            output.ShowStudies(this.FacultyComboBox, this.StudiesComboBox);
        }

        private void StudiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionList.Items.Clear();
            DatabaseProcessor dbProcessor = new DatabaseProcessor();
            DataTable table = dbProcessor.LoadForumThreads();

            UIOutput output = new UIOutput();
            output.ShowForumThreads(table,
                                    QuestionList,
                                    FacultyComboBox.SelectedItem.ToString(),
                                    StudiesComboBox.SelectedItem.ToString());
        }

        private void QuestionList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (QuestionList.SelectedItems.Count == 1)
            {
                DatabaseProcessor dbProcessor = new DatabaseProcessor();
                DataTable table = dbProcessor.LoadQuestions();
                QuestionWindow form = new QuestionWindow(table,
                                                         FacultyComboBox.SelectedItem.ToString(),
                                                         StudiesComboBox.SelectedItem.ToString());
                form.Show();
            }
        }
    }
}
