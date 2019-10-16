using StudyLabsApp.DatabaseIO;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLabsApp
{
    public partial class SignUpWindow : Form
    {
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

        public static ResXResourceReader Faculties = new ResXResourceReader
                (projectDirectory + @"\Resources\Faculties.resx");

        public static ResXResourceReader Studies = new ResXResourceReader
                (projectDirectory + @"\Resources\Faculties_and_studies.resx");

        public SignUpWindow()
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
                    AStuddyBuddy StuddyBuddy = new AStuddyBuddy(NicknameBox.Text.ToString(),
                                                           LinkBox.Text.ToString(),
                                                           FacultyComboBox.SelectedItem.ToString(),
                                                           StudiesComboBox.SelectedItem.ToString());

                    RegexChecker regexObject = new RegexChecker();
                    bool nicknameValid = regexObject.CheckNickname(StuddyBuddy.Nickname);
                    bool linkValid = regexObject.CheckLink(StuddyBuddy.Link);
                    bool personExists = DatabaseProcessor.FindExistingPerson(StuddyBuddy);

                    if (nicknameValid && linkValid && !personExists)
                    {
                        DatabaseProcessor.AddEntryToDatabase(StuddyBuddy);

                        MessageBox.Show("Your nickname: "  + StuddyBuddy.Nickname   + Environment.NewLine +
                                        "Your Link: "      + StuddyBuddy.Link       + Environment.NewLine +
                                        "Chosen faculty: " + StuddyBuddy.Faculty    + Environment.NewLine +
                                        "Chosen studies: " + StuddyBuddy.Studies);
                        this.Close();
                    }
                    else if(!nicknameValid)
                    {
                        MessageBox.Show("Nickname is not valid");
                    }
                    else if (!linkValid)
                    {
                        MessageBox.Show("Link is not valid");
                    }
                    else if (personExists)
                    {
                        MessageBox.Show("This person already exists");
                    }
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
