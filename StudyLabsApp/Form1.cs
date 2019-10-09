using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLabsApp
{
    /// <summary>
    /// Study buddy application
    /// </summary>
    public partial class Window : Form
    {
        ResXResourceReader Faculties = new ResXResourceReader
                (@"C:\Users\Saulius\source\repos\Sauliuspp\StudyLabs-Inc\StudyLabsApp\Resources\Faculties.resx");

        ResXResourceReader Studies = new ResXResourceReader
                (@"C:\Users\Saulius\source\repos\Sauliuspp\StudyLabs-Inc\StudyLabsApp\Resources\Faculties_and_studies.resx");

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Window()
        {
            InitializeComponent();
            /*
            FacultyComboBox.Items.Add("Faculty of Chemistry and Geosciences");
            FacultyComboBox.Items.Add("Faculty of Communication");
            FacultyComboBox.Items.Add("Faculty of Law");
            FacultyComboBox.Items.Add("Faculty of Economics and Business Administration");
            FacultyComboBox.Items.Add("Faculty of History");
            FacultyComboBox.Items.Add("Faculty of Mathematics and Informatics");
            FacultyComboBox.Items.Add("Faculty of Medicine");
            FacultyComboBox.Items.Add("Faculty of Philology");
            FacultyComboBox.Items.Add("Faculty of Philosophy");
            FacultyComboBox.Items.Add("Faculty of Physics");
            FacultyComboBox.Items.Add("Institute of International Relations and Political Science");
            FacultyComboBox.Items.Add("Kaunas Faculty");
            */

            // Create an IDictionaryEnumerator to iterate through the resources.
            IDictionaryEnumerator FacultiesDictionary = Faculties.GetEnumerator();

            // Iterate through the resources and display the contents
            foreach (DictionaryEntry d in Faculties)
            {
                FacultyComboBox.Items.Add(d.Key.ToString());
            }

        }

        #endregion

        private void EnterForums_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available in current version");
            //MainMenuPanel.Visible = false;
            //StuddyBuddy.Visible = false;
        }

        private void FindStuddyBuddies_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = false;
            StuddyBuddy.Visible = false;
            PanelForUniversityList.Visible = true;

        }

        private void BecomeAStuddyBuddy_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            PanelForUniversityList.Visible = false;
            MainMenuPanel.Visible = true;
            StuddyBuddy.Visible = true;
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudiesComboBox.Items.Clear();
            // Create an IDictionaryEnumerator to iterate through the resources.
            IDictionaryEnumerator StudiesDictionary = Studies.GetEnumerator();

            // Iterate through the resources and display the contents
            foreach (DictionaryEntry d in Studies)
            {
                int studiesValue = Int32.Parse(d.Value.ToString());

                if (studiesValue == FacultyComboBox.SelectedIndex)
                {
                    StudiesComboBox.Items.Add(d.Key.ToString());
                }
            }
        }
    }
}
