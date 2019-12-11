using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    class ThreadsDataStore : IDataStore<ForumThread>
    {
        private readonly List<ForumThread> forumThreads;

        public ThreadsDataStore(string studies)
        {
            forumThreads = new List<ForumThread>();
            GetThreads(studies);
        }

        private void GetThreads(string studies)
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

                try
                {
                    SqlCommand command = new SqlCommand("SELECT Id, Creator, Topic, Description, Faculty, Studies FROM [dbo].[ForumThread] " +
                                                        "WHERE Studies LIKE @studies", cn);
                    command.Parameters.AddWithValue("@studies", "%" + studies.ToLower() + "%");

                    adapter.SelectCommand = command;

                    adapter.Fill(ds, "ForumThread");

                    DataTable dataTable = ds.Tables[0];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        forumThreads.Add(new ForumThread()
                        {
                            Id          = (int) row["Id"],
                            Creator     = row["Creator"].ToString(),
                            Topic       = row["Topic"].ToString(),
                            Description = row["Description"].ToString(),
                            Studies     = row["Studies"].ToString(),
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
        public async Task<bool> AddItemAsync(ForumThread item)
        {
            forumThreads.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ForumThread item)
        {
            var oldItem = forumThreads.Where((ForumThread arg) => arg.Creator == item.Creator).FirstOrDefault();
            forumThreads.Remove(oldItem);
            forumThreads.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = forumThreads.Where((ForumThread arg) => arg.Creator == id).FirstOrDefault();
            forumThreads.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ForumThread> GetItemAsync(string id)
        {
            return await Task.FromResult(forumThreads.FirstOrDefault(s => s.Creator == id));
        }

        public async Task<IEnumerable<ForumThread>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(forumThreads);
        }
    }
}
