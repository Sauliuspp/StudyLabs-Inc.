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
            IsEnabled = false;
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

                try
                {
                    SqlCommand command = new SqlCommand("SELECT Id, Username, Password FROM [dbo].[StuddyBuddy] " +
                                                        "WHERE Username = @username" +
                                                        "      AND " +
                                                        "      Password = @password", cn);
                    command.Parameters.AddWithValue("@username", usernameField.Text);
                    command.Parameters.AddWithValue("@password", passwordField.Text);
               
                    adapter.SelectCommand = command;
                
                    adapter.Fill(ds, "StuddyBuddy");

                    string studdyBuddyUsername = (string)ds.Tables[0].Rows[0]["Username"];
                    string studdyBuddyPassword = (string)ds.Tables[0].Rows[0]["Password"];
                    Console.WriteLine(studdyBuddyUsername);
                    Console.WriteLine(studdyBuddyPassword);

                    adapter.Dispose();
                    IsEnabled = true;
                }
                catch (SqlException ex)
                {
                    IsEnabled = true;
                    adapter.Dispose();
                    await DisplayAlert("Alert", "Error with the database, try again", "OK");
                    return;
                }
                catch (Exception ex)
                {
                    IsEnabled = true;
                    adapter.Dispose();
                    await DisplayAlert("Alert", "Could not log in, try again", "OK");
                    return;
                }

                adapter.Dispose();
            }
        }
    }
}