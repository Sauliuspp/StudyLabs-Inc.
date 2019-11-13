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
using StudyLabsApp.ServiceReferenceDB;

namespace StudyLabsApp
{
    public partial class RankingsWindow : Form
    {
        string faculty;
        string studies;
        WebService2SoapClient dbObj;
        public RankingsWindow(ComboBox faculty, ComboBox studies)
        {
            InitializeComponent();
            if (faculty.SelectedItem == null)
            {
                MessageBox.Show("Choose faculty and studies");
            }
            else
            {
                this.faculty = faculty.SelectedItem.ToString();
                if (studies.SelectedItem != null)
                {
                    this.studies = studies.SelectedItem.ToString();
                }
                this.Show();
            }
        }

        private void RankingsWindow_Load(object sender, EventArgs e)
        {
            //WEB SERVICE DB LoadData
            dbObj = new WebService2SoapClient();
            DatabaseProcessor DBprocessor = new DatabaseProcessor();
            DataTable table = dbObj.LoadData();
            UIOutput displayer = new UIOutput();
            displayer.DisplayData(table, StuddyBuddyList, faculty);
            //END
        }

        private void StuddyBuddyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
