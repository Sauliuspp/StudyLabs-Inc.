using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using StudyLabsApp.UserIO;
using StudyLabsApp.DatabaseIO;

namespace StudyLabsApp
{
    public partial class StuddyBuddyListWindow : Form
    {
        string faculty;
        string studies;

        public StuddyBuddyListWindow(ComboBox faculty, ComboBox studies)
        {
            InitializeComponent();
            if (faculty.SelectedItem == null || studies.SelectedItem == null)
            {
                MessageBox.Show("Choose faculty and studies");
            }
            else 
            {
                this.faculty = faculty.SelectedItem.ToString();
                this.studies = studies.SelectedItem.ToString();
                this.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DatabaseProcessor DBprocessor = new DatabaseProcessor();
            DataTable table = DBprocessor.LoadData();
            UIOutput displayer = new UIOutput();
            displayer.DisplayData(table, listView: StuddyBuddyList, selectedFaculty: faculty, selectedStudies: studies);
        }

        private void StuddyBuddyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
