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

            string sql_Text = "INSERT INTO StuddyBuddy ([Nickname],[Facebook],[Faculty],[Studies],[Status],[Points]) VALUES('"
                + entry.Nickname + "','" +
                entry.Link + "','" +
                entry.Faculty + "','" +
                entry.Studies + "','" +
                (int)Level.Starter + "','" +
                0 +  "')";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();
        }

        public DataTable LoadStuddyBuddyData() // Copy what is in form 4
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

            return table;
        }

        public DataTable LoadForumThreads()
        {
            //load list
            string cn_string = Properties.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM ForumThread";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            adapter.Fill(table);

            return table;
        }

        public DataTable LoadDiscussions()
        {
            //load list
            string cn_string = Properties.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM Question";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            adapter.Fill(table);

            return table;
        }

        public DataTable LoadFilteredDiscussion(int id)
        {
            //load list
            string cn_string = Properties.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT Nickname, Time, Reply " +
                              "FROM Question, " +
                              "WHERE QuestionId = " + id;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            adapter.Fill(table);

            return table;
        }

        public bool FindExistingPerson(AStuddyBuddy person)
        {
            DataTable table = LoadStuddyBuddyData();

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
