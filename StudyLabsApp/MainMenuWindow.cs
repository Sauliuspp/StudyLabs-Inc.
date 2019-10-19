﻿using System;
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
    public partial class MainMenuWindow : Form
    {
        public static string workingDirectory = Environment.CurrentDirectory;
        public static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

        public static ResXResourceReader Faculties = new ResXResourceReader
                (projectDirectory + @"\Resources\Faculties.resx");

        public static ResXResourceReader Studies = new ResXResourceReader
                (projectDirectory + @"\Resources\Faculties_and_studies.resx");

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainMenuWindow()
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
            SignUpWindow form3 = new SignUpWindow();
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
            FacultyComboBox.SelectedItem = "";

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            StuddyBuddyListWindow form = new StuddyBuddyListWindow(FacultyComboBox,
                                                                   StudiesComboBox);
        }

        private void RankingsButton_Click_1(object sender, EventArgs e)
        {
            RankingsWindow form = new RankingsWindow(FacultyComboBox,
                                                     StudiesComboBox);
        }
    }
}
