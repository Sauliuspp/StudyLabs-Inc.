using EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

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
            using (var dc = new DataModel())
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

