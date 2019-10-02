using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Window()
        {
            InitializeComponent();
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

        private void ReturnToMainMenuButton_Click(object sender, EventArgs e)
        {
            PanelForUniversityList.Visible = false;
            MainMenuPanel.Visible = true;
            StuddyBuddy.Visible = true;
        }

        private void ChemistryGeosciencesButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void BecomeAStuddyBuddy_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
