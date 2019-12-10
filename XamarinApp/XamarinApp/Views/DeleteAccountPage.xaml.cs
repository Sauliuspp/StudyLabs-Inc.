using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeleteAccountPage : ContentPage
    {
        public string username { get; set; }
        public string password { get; set; }

        public DeleteAccountPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private async void DeleteAccount_ClickedAsync(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:studylabs-inc.database.windows.net,1433;" +
                                        "Initial Catalog=StudyLabs_DB;" +
                                        "Persist Security Info=False;User ID=studylabs;" +
                                        "Password=Objektinis2019;" +
                                        "MultipleActiveResultSets=False;Encrypt=True;" +
                                        "TrustServerCertificate=False;" +
                                        "Connection Timeout=30;";

            string deleteQuery = "DELETE FROM [dbo].[StuddyBuddy] WHERE Username = @username";

            string selectQuery = "SELECT Username " +
                                 "FROM [dbo].[StuddyBuddy] " +
                                 "WHERE Username = @username";

            if (DeleteConfirmation.SelectedItem.ToString().Equals("Yes"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand select = new SqlCommand(selectQuery, connection);
                        select.Parameters.AddWithValue("@username", username);
                        adapter.SelectCommand = select;

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "StuddyBuddy");

                        SqlCommand delete = new SqlCommand(deleteQuery, connection);
                        adapter.DeleteCommand = delete;
                        delete.CommandType = CommandType.Text;
                        delete.Parameters.Add("@username", SqlDbType.VarChar, 20, "Username");

                        ds.Tables[0].Rows[0].Delete();

                        adapter.Update(ds.Tables[0]);
                        adapter.Dispose();

                        await Navigation.PopToRootAsync();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    adapter.Dispose();
                    await DisplayAlert("Alert", "Try again", "OK");
                }
                finally
                {
                    adapter.Dispose();
                    IsEnabled = true;
                }
            }
        }
    }
}