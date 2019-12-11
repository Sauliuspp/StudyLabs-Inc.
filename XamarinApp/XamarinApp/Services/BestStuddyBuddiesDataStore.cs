using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    class BestStuddyBuddiesDataStore : IDataStore<BestStuddyBuddy>
    {
        readonly List<BestStuddyBuddy> threadsStatistics;

        public BestStuddyBuddiesDataStore()
        {
            threadsStatistics = new List<BestStuddyBuddy>(); 
            GetThreadStatistics();
        }

        private void GetThreadStatistics()
        {
            DataContext dc = new DataContext();
            //DataTable studdyBuddies = dc.GetStuddyBuddies();
            //var partialResult = (from c in 
            //                     join o in db.Orders
            //
            //                     on c.customer_id equals o.customer_id
            //                     select new
            //                     {
            //                         c.name,
            //                         o.order_total,
            //                         o.order_date
            //                     }).OrderBy(m => m.order_date.Month).ThenBy(y => y.order_date.Year);
        }

        public async Task<bool> AddItemAsync(BestStuddyBuddy item)
        {
            threadsStatistics.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(BestStuddyBuddy item)
        {
            var oldItem = threadsStatistics.Where((BestStuddyBuddy arg) => arg.Username == item.Username).FirstOrDefault();
            threadsStatistics.Remove(oldItem);
            threadsStatistics.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = threadsStatistics.Where((BestStuddyBuddy arg) => arg.Username == id).FirstOrDefault();
            threadsStatistics.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<BestStuddyBuddy> GetItemAsync(string id)
        {
            return await Task.FromResult(threadsStatistics.FirstOrDefault(s => s.Username == id));
        }

        public async Task<IEnumerable<BestStuddyBuddy>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(threadsStatistics);
        }
    }
}

