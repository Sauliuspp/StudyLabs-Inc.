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
using StudyLabsApp.ExtentionMethods;

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

        Lazy<DatabaseProcessor> DBprocessor;

        public SignUpWindow()
        {
            InitializeComponent();

            foreach (DictionaryEntry entry in Faculties)
            {
                FacultyComboBox.Items.Add(entry.Key.ToString());
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
                    DBprocessor = new Lazy<DatabaseProcessor>();
                    bool nicknameValid = regexObject.CheckNickname(StuddyBuddy.Nickname);
                    bool linkValid = regexObject.CheckLink(StuddyBuddy.Link);
                    bool personExists = DBprocessor.Value.FindExistingPerson(StuddyBuddy);

                    if (nicknameValid && linkValid && !personExists)
                    {
                        DBprocessor.Value.AddEntryToDatabase(StuddyBuddy);

                        MessageBox.Show("Your nickname: "  + StuddyBuddy.Nickname   + Environment.NewLine +
                                        "Your Link: "      + StuddyBuddy.Link       + Environment.NewLine +
                                        "Chosen faculty: " + StuddyBuddy.Faculty    + Environment.NewLine +
                                        "Chosen studies: " + StuddyBuddy.Studies    + Environment.NewLine +
                                        "Your level: "     + (Level) StuddyBuddy.Status);
                        //LevelUp(StuddyBuddy);
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

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudiesComboBox.Items.Clear();

            foreach (DictionaryEntry entry in Studies)
            {
                int studiesValue = Int32.Parse(entry.Value.ToString());

                if (studiesValue == FacultyComboBox.SelectedIndex)
                {
                    StudiesComboBox.Items.Add(entry.Key.ToString());
                }
            }

        }
        //A method to increase the level of a studdybuddy
        private void LevelUp(AStuddyBuddy StuddyBuddy)
        {
            int enumvalue = StuddyBuddy.Status;
            //Extension method usage
            if (enumvalue.IsGreaterThan<int>(10))
            {
                MessageBox.Show("You have reached maximum level possible! Good job! ");
                return;
            }

            StuddyBuddy.Status = enumvalue + 1;

            //Boxing happening. Enum type to string
            MessageBox.Show("Your new level: " + (Level) StuddyBuddy.Status);
        }
    }
}
