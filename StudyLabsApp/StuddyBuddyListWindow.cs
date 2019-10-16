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

        public StuddyBuddyListWindow(string faculty, string studies)
        {
            InitializeComponent();
            this.faculty = faculty;
            this.studies = studies;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable table = DatabaseProcessor.LoadData();
            UIOutput.DisplayData(table, StuddyBuddyList, faculty, studies);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_SBuddy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
