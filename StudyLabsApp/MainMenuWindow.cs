using StudyLabsApp.UserIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        private int maxNumber = 0;
        private int currentNumber = 0;

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainMenuWindow()
        {
            InitializeComponent();
            this.Shown += new EventHandler(MainMenuWindow_Shown);

            NextImageButton.Enabled = false;
            PreviousImageButton.Enabled = true;

            APIHelper.InitializeClient();
            UIOutput output = new UIOutput();
            output.ShowFaculties(this.FacultyComboBox);
        }

        #endregion

        private void MainMenuWindow_Load(object sender, EventArgs e)
        {
            lForums.Visible = false;
            panelLeft.Visible = false;
        }

        private async void MainMenuWindow_Shown(Object sender, EventArgs e)
        {
            await LoadImage();
        }

        private void EnterForums_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = EnterForums.Height;
            panelLeft.Top = EnterForums.Top;
            PanelForUniversityList.Visible = false;
            //lForums.Visible = true;
            ForumsWindow form = new ForumsWindow();
            form.Show();
            //MainMenuPanel.Visible = false;
            //StuddyBuddy.Visible = false;
        }

        private void FindStuddyBuddies_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = FindStuddyBuddies.Height;
            panelLeft.Top = FindStuddyBuddies.Top;
            PanelForUniversityList.Visible = true;

        }

        private void BecomeAStuddyBuddy_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = true;
            panelLeft.Height = BecomeAStuddyBuddy.Height;
            panelLeft.Top = BecomeAStuddyBuddy.Top;
            SignUpWindow form3 = new SignUpWindow();
            form3.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            PanelForUniversityList.Visible = false;
            panelLeft.Visible = false;
            lForums.Visible = false;
            StuddyBuddy.Visible = true;
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudiesComboBox.Items.Clear();
            FacultyComboBox.SelectedItem = "";

            UIOutput output = new UIOutput();
            output.ShowStudies(this.FacultyComboBox, this.StudiesComboBox);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            StuddyBuddyListWindow form = new StuddyBuddyListWindow(FacultyComboBox,
                                                                   StudiesComboBox);
        }

        private void RankingsButton_Click(object sender, EventArgs e)
        {
            RankingsWindow form = new RankingsWindow(FacultyComboBox,
                                                     StudiesComboBox);
        }

        private async void PreviousImageButton_Click(object sender, EventArgs e)
        {
            if (currentNumber > 1)
            {
                currentNumber -= 1;
                NextImageButton.Enabled = true;
                await LoadImage(currentNumber);

                if (currentNumber == 1)
                {
                    PreviousImageButton.Enabled = false;
                }

            }
        }

        private async void NextImageButton_Click(object sender, EventArgs e)
        {
            if (currentNumber < maxNumber)
            {
                currentNumber += 1;
                PreviousImageButton.Enabled = true;
                await LoadImage(currentNumber);

                if (currentNumber == maxNumber)
                {
                    NextImageButton.Enabled = false;
                }
            }
        }

        private async Task LoadImage(int imageNumber = 0)
        {
            var comic = await ComicProcessor.LoadComic(imageNumber);

            if (imageNumber == 0)
            {
                maxNumber = comic.Num;
            }

            currentNumber = comic.Num;

            var uriSource = new Uri(comic.Img, UriKind.Absolute);
            ComicBox.LoadAsync(uriSource.ToString());
        }
    }
}
