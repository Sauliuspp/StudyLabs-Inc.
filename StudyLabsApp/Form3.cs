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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(FacultyComboBox.SelectedIndex>0)
            {
                string selectedOption = FacultyComboBox.SelectedItem.ToString();
                string nickname = NicknameBox.Text.ToString();
                string link = LinkBox.Text.ToString();
                MessageBox.Show("Your nickname: " + nickname + Environment.NewLine + "Your Link: " + link + Environment.NewLine + "Chosen faculty: " + selectedOption);
                this.Close();
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

        }
    }
}
