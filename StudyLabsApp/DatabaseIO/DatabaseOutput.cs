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
    public static class DatabaseOutput
    {
        public static DataTable LoadData() // Kopija kas yra Form4 reikia iskelti WIP
        {
            //load list
            string cn_string = Properties.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM StuddyBuddy";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            adapter.Fill(table);

            //Show database list
            // lst_SBuddy.DisplayMember = "Nickname";
            // lst_SBuddy.ValueMember = "Id";
            // lst_SBuddy.DataSource = tbl;
            return table;
        }
    }
}
