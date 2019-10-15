using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp
{
    public static class DatabaseInput
    {
        public static void AddEntryToDatabase(AStuddyBuddy entry)
        {
            //load list
            string cn_string = Properties.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string newBuddyNick = entry.nickname;
            string newBuddyLink = entry.link;
            string newBuddyFaculty = entry.faculty;
            string newBuddyStudies = entry.studies;

            string sql_Text = "INSERT INTO StuddyBuddy ([Nickname],[Facebook],[Faculty],[Studies]) VALUES('" + newBuddyNick + "'," +
                "'" + newBuddyLink + "','" + newBuddyFaculty + "','" + newBuddyStudies + "')";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();
        }
    }
}
