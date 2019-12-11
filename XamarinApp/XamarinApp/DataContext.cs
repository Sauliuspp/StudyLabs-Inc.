using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace XamarinApp
{
    public class DataContext
    {
        public DataTable GetStuddyBuddies()
        {
            string connectionString = "Server=tcp:studylabs-inc.database.windows.net,1433;" +
                                        "Initial Catalog=StudyLabs_DB;" +
                                        "Persist Security Info=False;User ID=studylabs;" +
                                        "Password=Objektinis2019;" +
                                        "MultipleActiveResultSets=False;Encrypt=True;" +
                                        "TrustServerCertificate=False;" +
                                        "Connection Timeout=30;";


            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                try
                {
                    SqlCommand command = new SqlCommand("SELECT Id, Username, Password FROM [dbo].[StuddyBuddy] " +
                                                        "WHERE Username = @username" +
                                                        "      AND " +
                                                        "      Password = @password", cn);
                    //command.Parameters.AddWithValue("@username", usernameField.Text);
                    //command.Parameters.AddWithValue("@password", passwordField.Text);

                    adapter.SelectCommand = command;

                    adapter.Fill(ds, "StuddyBuddy");

                    string studdyBuddyUsername = (string)ds.Tables[0].Rows[0]["Username"];
                    string studdyBuddyPassword = (string)ds.Tables[0].Rows[0]["Password"];

                    adapter.Dispose();
                    return dt;
                }
                catch (SqlException ex)
                {
                    adapter.Dispose();
                    return null;
                }
                catch (Exception ex)
                {
                    adapter.Dispose();
                    return null;
                }
            }
        }
    }
}
