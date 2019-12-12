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
        private async void DataInsert(object sender, EventArgs e)
        {
            IsEnabled = false;
            string connectionString = "Server=tcp:studylabs-inc.database.windows.net,1433;" +
                                        "Initial Catalog=StudyLabs_DB;" +
                                        "Persist Security Info=False;User ID=studylabs;" +
                                        "Password=Objektinis2019;" +
                                        "MultipleActiveResultSets=False;Encrypt=True;" +
                                        "TrustServerCertificate=False;" +
                                        "Connection Timeout=30;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Username, Password, Link, Faculty, Studies, Status, Points FROM [dbo].[StuddyBuddy]", connection);
                try
                {
                    SqlCommand insert = new SqlCommand();
                    insert.Connection = connection;
                    insert.CommandType = CommandType.Text;
                    insert.CommandText = "INSERT INTO [dbo].[StuddyBuddy] " +
                                        "(Username, Password, Link, Faculty, Studies, Status, Points)" +
                                         "VALUES(@Us,@Pw,@Lk,@Fy, @Stu, @Sts, @Pt)";

                    insert.Parameters.Add(new SqlParameter("@Us", SqlDbType.VarChar, 20, "FirstName"));
                    insert.Parameters.Add(new SqlParameter("@Pw", SqlDbType.VarChar, 30, "Password"));
                    insert.Parameters.Add(new SqlParameter("@Lk", SqlDbType.VarChar, 50, "Link"));
                    insert.Parameters.Add(new SqlParameter("@Fy", SqlDbType.VarChar, 30, "Faculty"));
                    insert.Parameters.Add(new SqlParameter("@Stu", SqlDbType.VarChar, 30, "Faculty"));
                    insert.Parameters.Add(new SqlParameter("@Sts", SqlDbType.Int, 10, "Status"));
                    insert.Parameters.Add(new SqlParameter("@Pt", SqlDbType.Int, 10, "Points"));

                    adapter.InsertCommand = insert;

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "StuddyBuddy");

                    DataRow newRow = ds.Tables[0].NewRow();
                    newRow["Username"] = "Meskiukas";
                    newRow["Password"] = "meskiukas";
                    newRow["Link"] = "www.facebook.com/Meskiukas";
                    newRow["Faculty"] = "Faculty of physics";
                    newRow["Studies"] = "Physics";
                    newRow["Status"] = 2;
                    newRow["Points"] = 34;
                    ds.Tables[0].Rows.Add(newRow);

                    adapter.Update(ds.Tables[0]);
                    adapter.Dispose();
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