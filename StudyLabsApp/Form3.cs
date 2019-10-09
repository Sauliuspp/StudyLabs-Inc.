using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLabsApp
{
    public partial class Form3 : Form
    {
        ResXResourceReader Faculties = new ResXResourceReader
                (@"C:\Users\Legion\source\repos\Sauliuspp\StudyLabs-Inc\StudyLabsApp\Resources\Faculties.resx");

        ResXResourceReader Studies = new ResXResourceReader
                (@"C:\Users\Legion\source\repos\Sauliuspp\StudyLabs-Inc\StudyLabsApp\Resources\Faculties_and_studies.resx");

        public Form3()
        {
            InitializeComponent();

            // Create an IDictionaryEnumerator to iterate through the resources.
            IDictionaryEnumerator FacultiesDictionary = Faculties.GetEnumerator();

            // Iterate through the resources and display the contents
            foreach (DictionaryEntry d in Faculties)
            {
                FacultyComboBox.Items.Add(d.Key.ToString());
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(FacultyComboBox.SelectedIndex>=0)
            {
                if(StudiesComboBox.SelectedIndex>=0)
                {
                    string selectedOption1 = FacultyComboBox.SelectedItem.ToString();
                    string selectedOption2 = StudiesComboBox.SelectedItem.ToString();
                    string nickname = NicknameBox.Text.ToString();
                    string link = LinkBox.Text.ToString();

                    // Create a studdy buddy and save all of the atributes in a class
                    AStuddyBuddy StuddyBuddy = new AStuddyBuddy(nickname,link,selectedOption1,selectedOption2);


                    MessageBox.Show("Your nickname: " + StuddyBuddy.Get_nickname() + Environment.NewLine + "Your Link: " + StuddyBuddy.Get_link() + Environment.NewLine +
                        "Chosen faculty: " + StuddyBuddy.Get_faculty() + Environment.NewLine + "Chosen studies: " + StuddyBuddy.Get_studies()) ;
                    this.Close();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NicknameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void LinkBox_TextChanged(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
