using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp.DatabaseIO
{
    public class DatabaseProcessor
    {
        public void AddEntryToDatabase(AStuddyBuddy entry)
        {
            //load list
            string cn_string = Properties.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string newBuddyNick = entry.Nickname;
            string newBuddyLink = entry.Link;
            string newBuddyFaculty = entry.Faculty;
            string newBuddyStudies = entry.Studies;
            int newBuddyStatus = (int) Level.Starter;
            int newBuddyPoints = 0;

            string sql_Text = "INSERT INTO StuddyBuddy ([Nickname],[Facebook],[Faculty],[Studies],[Status],[Points]) VALUES('"
                + newBuddyNick + "','" +
                newBuddyLink + "','" +
                newBuddyFaculty + "','" +
                newBuddyStudies + "','" +
                newBuddyStatus + "','" +
                newBuddyPoints +  "')";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();
        }

        public DataTable LoadData() // Kopija kas yra Form4 reikia iskelti WIP
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

        public bool FindExistingPerson(AStuddyBuddy person)
        {
            DataTable table = LoadData();

            foreach (DataRow row in table.Rows)
            {
                AStuddyBuddy tableBuddy = new AStuddyBuddy(row.Field<string>("Nickname"),
                                                      row.Field<string>("Facebook"),
                                                      row.Field<string>("Faculty"),
                                                      row.Field<string>("Studies"));
                if (person.Equals(tableBuddy))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
