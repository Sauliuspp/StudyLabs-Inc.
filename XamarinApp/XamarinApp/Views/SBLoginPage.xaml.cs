using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Models;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SBLoginPage : ContentPage
    {
        public SBLoginPage()
        {
            InitializeComponent();
        }

        private async void LoginToSB_ClickedAsync(object sender, EventArgs e)
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
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT Id, Username FROM [dbo].[StuddyBuddy] WHERE Username = @username", cn);
                command.Parameters.AddWithValue("@username", usernameField.Text);

                adapter.SelectCommand = command;

                adapter.Fill(ds, "StuddyBuddy");

                try
                {
                    int studdyBuddyID = (int)ds.Tables[0].Rows[0]["Id"];
                    string studdyBuddyUsername = (string)ds.Tables[0].Rows[0]["Username"];
                    Console.WriteLine(studdyBuddyID);
                    Console.WriteLine(studdyBuddyUsername);
                }
                catch(Exception ex)
                {
                    await DisplayAlert("Alert", "Could not log in, try again", "OK");
                }

                command.CommandText = "SELECT Id, Password FROM [dbo].[Password] WHERE Password = @password";
                command.Parameters.AddWithValue("@password", passwordField.Text);

                adapter.SelectCommand = command;

                ds = new DataSet();
                adapter.Fill(ds, "Password");

                try
                {
                    int passwordID = (int)ds.Tables[0].Rows[0]["Id"];
                    string password = (string)ds.Tables[0].Rows[0]["Password"];
                    Console.WriteLine(passwordID);
                    Console.WriteLine(password);
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Alert", "Could not log in, try again", "OK");
                }

                cn.Close();
                adapter.Dispose();
            }
        }
    }
}