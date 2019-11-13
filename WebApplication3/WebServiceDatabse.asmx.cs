using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {
        struct Information
        {
            public string newBuddyNick;
            public string newBuddyLink;
            public string newBuddyFaculty;
            public string newBuddyStudies;
            public int newBuddyStatus;
            public int newBuddyPoints;

            public Information(
                string nick = "Not provided",
                string link = "Not provided",
                string faculty = "Not provided",
                string studies = "Not provided",
                int status = 1,
                int points = 0)
            {
                newBuddyNick = nick;
                newBuddyLink = link;
                newBuddyFaculty = faculty;
                newBuddyStudies = studies;
                newBuddyStatus = status;
                newBuddyPoints = points;
            }
        }

        /*
        [WebMethod]
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
        */

        [WebMethod]
        public DataTable LoadData()
        {
            //load list
            string cn_string = App_Data.Settings.Default.StuddyBuddyDBConnectionString;
            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();


            string sql_Text = "SELECT * FROM StuddyBuddy";

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            table.TableName = "Studdy Buddy list";
            adapter.Fill(table);

            //Show database list
            // lst_SBuddy.DisplayMember = "Nickname";
            // lst_SBuddy.ValueMember = "Id";
            // lst_SBuddy.DataSource = tbl;
            return table;
        }

        /*
        [WebMethod]
        public void AddEntryToDatabase(AStuddyBuddy entry)
        {
            //Default parameter initiation from struct
            Information info = new Information();

            //load list
            string cn_string = App_Data.Settings.Default.StuddyBuddyDBConnectionString;

            //Database
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            info.newBuddyNick = entry.Nickname;
            info.newBuddyLink = entry.Link;
            info.newBuddyFaculty = entry.Faculty;
            info.newBuddyStudies = entry.Studies;
            info.newBuddyStatus = (int)Level.Starter;
            info.newBuddyPoints = 0;

            string sql_Text = "INSERT INTO StuddyBuddy ([Nickname],[Facebook],[Faculty],[Studies],[Status],[Points]) VALUES('"
                + info.newBuddyNick + "','" +
                info.newBuddyLink + "','" +
                info.newBuddyFaculty + "','" +
                info.newBuddyStudies + "','" +
                info.newBuddyStatus + "','" +
                info.newBuddyPoints + "')";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();
        }
        */

    }
}
