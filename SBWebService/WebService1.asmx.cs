using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SBWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]

        public void AddEntryToDatabase()//(AStuddyBuddy entry)
        {
            //load list
            string cn_string = StudyLabsApp.Properties.Settings.Default.StuddyBuddyDBConnectionString;
            /*
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
            */
        }
    }
}
