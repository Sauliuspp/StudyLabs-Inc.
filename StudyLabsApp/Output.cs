using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace StudyLabsApp
{
    class Output
    {

        public Output(String nick, String link, String faculty, String studies)
        {
            add_Entry_to_DB(nick, link, faculty, studies);
        }

        public void load_List() // Kopija kas yra Form4 reikia iskelti WIP
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

            //Show database list
            // lst_SBuddy.DisplayMember = "Nickname";
            // lst_SBuddy.ValueMember = "Id";

            // lst_SBuddy.DataSource = tbl;

        }

        private void add_Entry_to_DB(String nick, String link, String faculty, String studies)
        {
            //load list
            string cn_string = Properties.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sNew_Buddy_Nick = nick;
            string sNew_Buddy_Link = link;
            string sNew_Buddy_Faculty = faculty;
            string sNew_Buddy_Studies = studies;

            string sql_Text = "INSERT INTO StuddyBuddy ([Nickname],[Facebook],[Faculty],[Studies]) VALUES('"+sNew_Buddy_Nick +"'," +
                "'" + sNew_Buddy_Link + "','" + sNew_Buddy_Faculty + "','" + sNew_Buddy_Studies + "')";
        
            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();
        }




    }
}
