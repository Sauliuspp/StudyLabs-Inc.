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
        public StuddyBuddyListWindow()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable table = DatabaseProcessor.LoadData();
            UIOutput.DisplayData(table, listView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
