using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using StudyLabsApp.Properties;

namespace StudyLabsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BiochemijaRTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string resource_data = Properties.Resources.Biochemija;
            List<string> bioC1 = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            BiochemijaRTxtBox1.Lines = bioC1.ToArray();

            string resource_data1 = Properties.Resources.Biochemija2;
            List<string> bioC2 = resource_data1.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            BiochemijaRTxtBox2.Lines = bioC2.ToArray();

        }

        private void BiochemijaRTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
