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
    public partial class SBRegisterPage : ContentPage
    {
        public SBRegisterPage()
        {
            InitializeComponent();
        }

        private async void SignUp_Clicked(object sender, EventArgs e)
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Username, Link, Faculty, " +
                                                            "Studies, Status, Points FROM [dbo].[StuddyBuddy]", cn);

                try     // to do - autogenerate studddybuddy table id column
                {
                    SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[StuddyBuddy] (Username, Link, Faculty, Studies, Status, Points) " +
                                                    "VALUES ( @username, @link, @faculty, @studies, @status, @points );", cn);
                    insert.CommandType = CommandType.Text;

                    insert.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 20, "Username"));
                    insert.Parameters.Add(new SqlParameter("@link", SqlDbType.VarChar, 50, "Link"));
                    insert.Parameters.Add(new SqlParameter("@faculty", SqlDbType.VarChar, 30, "Faculty"));
                    insert.Parameters.Add(new SqlParameter("@studies", SqlDbType.VarChar, 30, "Studies"));
                    insert.Parameters.Add(new SqlParameter("@status", SqlDbType.Int, 4, "Status"));
                    insert.Parameters.Add(new SqlParameter("@points", SqlDbType.Int, 4, "Points"));

                    adapter.InsertCommand = insert;
                    adapter.Fill(ds, "StuddyBuddy");

                    DataRow newRow = ds.Tables[0].NewRow();
                    newRow["Username"] = nickEntry.Text;
                    newRow["Link"] = linkEntry.Text;
                    newRow["Faculty"] = facEntry.Text;
                    newRow["Studies"] = studEntry.Text;
                    newRow["Status"] = 1; // column does not belong to table Studdybuddy
                    newRow["Points"] = 0;

                    ds.Tables[0].Rows.Add(newRow);
                    adapter.Update(ds.Tables[0]);

                    ds = new DataSet();
                    adapter = new SqlDataAdapter("SELECT Password FROM [dbo].[Password]", cn);

                    insert = new SqlCommand("INSERT INTO [dbo].[Password] (Password) " +
                                                    "VALUES ( @password );", cn);

                    insert.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 30, "Password"));

                    adapter.InsertCommand = insert;
                    adapter.Fill(ds, "Password");

                    newRow = ds.Tables[0].NewRow();
                    newRow["Password"] = Password.Text;

                    ds.Tables[0].Rows.Add(newRow);
                    adapter.Update(ds.Tables[0]);
                }
                catch (Exception ex)
                {
                    cn.Close();
                    adapter.Dispose();
                    await DisplayAlert("Alert", "Could not register, try again", "OK");
                }

                cn.Close();
                adapter.Dispose();
            }
        }
    }
}