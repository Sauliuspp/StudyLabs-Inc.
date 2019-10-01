using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLabsApp
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void EnterForums_Click(object sender, EventArgs e)
        {
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
    }
}
