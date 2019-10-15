using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudyLabsApp
{
    public partial class StuddyBuddyListWindow : Form
    {
        public StuddyBuddyListWindow()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            load_Listview();
        }


        private void load_Listview() // DUOMENU IKELIMAS I LIST VIEW
        {
            //load list
            string cn_string = Properties.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM StuddyBuddy";

            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            adapter.Fill(tbl);

            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem(row[1].ToString());
                for (int i = 2; i < tbl.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView1.Items.Add(item);
            }


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_SBuddy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
