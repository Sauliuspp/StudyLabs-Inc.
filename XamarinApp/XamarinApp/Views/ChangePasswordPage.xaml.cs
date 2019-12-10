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
    public partial class ChangePasswordPage : ContentPage
    {
        public string username { get; set; }
        public string password { get; set; }

        public ChangePasswordPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private async void NewPasswordConfirm_ClickedAsync(object sender, EventArgs e)
        {
            IsEnabled = false;
            string connectionString = "Server=tcp:studylabs-inc.database.windows.net,1433;" +
                                        "Initial Catalog=StudyLabs_DB;" +
                                        "Persist Security Info=False;User ID=studylabs;" +
                                        "Password=Objektinis2019;" +
                                        "MultipleActiveResultSets=False;Encrypt=True;" +
                                        "TrustServerCertificate=False;" +
                                        "Connection Timeout=30;";

            string selectQuery = "SELECT Username, Password " +
                                 "FROM [dbo].[StuddyBuddy]" +
                                 "WHERE Username = @username " +
                                 "AND " +
                                 "      Password = @password";

            string updateQuery = "UPDATE [dbo].[StuddyBuddy] " +
                                 "SET Password = @newPassword " +
                                 "WHERE  Username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                try
                {
                    SqlCommand select = new SqlCommand(selectQuery, connection);
                    select.Parameters.AddWithValue("@username", username);
                    select.Parameters.AddWithValue("@password", password);
                    adapter.SelectCommand = select;
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "StuddyBuddy");

                    SqlCommand update = new SqlCommand(updateQuery, connection);
                    update.CommandType = CommandType.Text;

                    update.Parameters.Add("@newPassword", SqlDbType.VarChar, 30, "Password");
                    update.Parameters.Add("@username", SqlDbType.VarChar, 20, "Username");
                    adapter.UpdateCommand = update;

                    DataTable dataTable = ds.Tables[0];
                    dataTable.Rows[0]["Password"] = NewPassword.Text;

                    adapter.Update(dataTable);
                    adapter.Dispose();
                    password = NewPassword.Text;
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
                    await Navigation.PopAsync();
                    IsEnabled = true;
                }
            }
        }
    }
}