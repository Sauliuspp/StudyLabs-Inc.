using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq;
using XamarinApp.Services;
using EntityModel;

namespace XamarinApp.Models
{
    public class EntityFramework : DbContext, IDataStore<AStuddyBuddy>
    {      
        public EntityFramework() : base()
        {
        }
        public DbSet<AStuddyBuddy> Items { get; set; }

        string connectionString = "Server=tcp:studylabs-inc.database.windows.net,1433;" +
                                        "Initial Catalog=StudyLabs_DB;" +
                                        "Persist Security Info=False;User ID=studylabs;" +
                                        "Password=Objektinis2019;" +
                                        "MultipleActiveResultSets=False;Encrypt=True;" +
                                        "TrustServerCertificate=False;" +
                                        "Connection Timeout=30;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public async Task<bool> AddItemAsync(AStuddyBuddy item)
        {
            Items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(AStuddyBuddy item)
        {
            var oldItem = Items.Where((AStuddyBuddy arg) => arg.Nickname == item.Nickname).FirstOrDefault();
            Items.Remove(oldItem);
            Items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = Items.Where((AStuddyBuddy arg) => arg.Nickname == id).FirstOrDefault();
            Items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<AStuddyBuddy> GetItemAsync(string id)
        {
            return await Task.FromResult(Items.FirstOrDefault(s => s.Nickname == id));
        }

        public async Task<IEnumerable<AStuddyBuddy>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Items);
        }
    }
}
