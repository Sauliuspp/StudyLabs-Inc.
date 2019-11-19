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
using System.Data.SqlClient;

namespace StudyLabsApp
{
    public delegate void Message<in T>(T message);

    public partial class SignUpWindow : Form
    {
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

        public static ResXResourceReader Faculties = new ResXResourceReader
                (projectDirectory + @"\Resources\Faculties.resx");

        public static ResXResourceReader Studies = new ResXResourceReader
                (projectDirectory + @"\Resources\Faculties_and_studies.resx");

        Lazy<RegexChecker> regexObject = new Lazy<RegexChecker>();
        Lazy<DatabaseProcessor> DBprocessor = new Lazy<DatabaseProcessor>();

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

                    bool nicknameValid = regexObject.Value.CheckNickname(StuddyBuddy.Nickname, checkValidity);
                    bool linkValid = regexObject.Value.CheckLink(StuddyBuddy.Link, checkValidity);
                    bool personExists = DBprocessor.Value.FindExistingPerson(StuddyBuddy);

                    if (nicknameValid && linkValid && !personExists)
                    {
                        try
                        {
                            DBprocessor.Value.AddEntryToDatabase(StuddyBuddy);

                            MessageBox.Show("Your nickname: " + StuddyBuddy.Nickname + Environment.NewLine +
                                            "Your Link: " + StuddyBuddy.Link + Environment.NewLine +
                                            "Chosen faculty: " + StuddyBuddy.Faculty + Environment.NewLine +
                                            "Chosen studies: " + StuddyBuddy.Studies + Environment.NewLine +
                                            "Your level: " + (Level)StuddyBuddy.Status);
                            //LevelUp(StuddyBuddy);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                            Message<string> showMessage = delegate (string message)
                            {
                                MessageBox.Show(message);
                            };
                            showMessage("The student's information is invalid. " +
                                        "We could not be register the student to the system. " +
                                        "Please try again.");
                        }
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

        private bool checkValidity(Regex regex, string input)
        {
            if (regex.IsMatch(input))
            {
                return true;
            }
            else return false;
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
