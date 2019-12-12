using EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;
using System.Data.SqlClient;

namespace XamarinApp.Services
{
    class BestStuddyBuddiesDataStore : IDataStore<AStuddyBuddy>
    {
        List<AStuddyBuddy> bestBuddies;

        public BestStuddyBuddiesDataStore()
        {
            bestBuddies = new List<AStuddyBuddy>();
            GetStuddyBuddies();
        }
        public void GetStuddyBuddies()
        {
            using (var db = new EntityFramework())
            {
                bestBuddies = db.Items
                    .Where(b => b.Status > 20)
                    .OrderBy(b => b.Status)
                    .ToList();
            }
            /*using (var dc = new DataModel())
            {
                var query = dc.StuddyBuddies
                            .Where(x => x.Points > 20)
                            .OrderByDescending(x => x.Points);

                //var query = from buddy in dc.StuddyBuddies
                //            where buddy.Points > 20
                //            orderby buddy.Points descending
                //            select buddy;

                foreach (var a in query) // klaidą meta cia
                {
                    Console.WriteLine("asdafgdfsda");
                    Console.WriteLine("asdfsdfsasds");
                    Console.WriteLine("asfdasfdadfgs");
                }
            }*/
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
                    SqlCommand command = new SqlCommand("SELECT Id, Username, Password, Link, Faculty, Studies, Status, Points FROM [dbo].[StuddyBuddy] " +
                                                        "WHERE Points > 20", cn);

                    adapter.SelectCommand = command;

                    adapter.Fill(ds, "StuddyBuddy");

                    DataTable dataTable = ds.Tables[0];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        bestBuddies.Add(new AStuddyBuddy()
                        {
                            Id = (int)row["Id"],
                            Nickname = row["Username"].ToString(),
                            Password = row["Password"].ToString(),
                            Link = row["Link"].ToString(),
                            Faculty = row["Faculty"].ToString(),
                            Studies = row["Studies"].ToString(),
                            Status = (int)row["Status"],
                            Points = (int)row["Points"],

                        });
                    }

                    adapter.Dispose();
                }
                catch (Exception ex)
                {
                    adapter.Dispose();
                }
                finally
                {
                    adapter.Dispose();
                }
            }

        }
        public async Task<bool> AddItemAsync(AStuddyBuddy item)
        {
            bestBuddies.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(AStuddyBuddy item)
        {
            var oldItem = bestBuddies.Where((AStuddyBuddy arg) => arg.Nickname == item.Nickname).FirstOrDefault();
            bestBuddies.Remove(oldItem);
            bestBuddies.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = bestBuddies.Where((AStuddyBuddy arg) => arg.Nickname == id).FirstOrDefault();
            bestBuddies.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<AStuddyBuddy> GetItemAsync(string id)
        {
            return await Task.FromResult(bestBuddies.FirstOrDefault(s => s.Nickname == id));
        }

        public async Task<IEnumerable<AStuddyBuddy>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(bestBuddies);
        }
    }
}

