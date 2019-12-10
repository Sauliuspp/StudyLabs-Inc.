using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    public class StudiesDataStore : IDataStore<Studies>
    {
        readonly List<Studies> items;

        public StudiesDataStore()
        {
            items = GetStudies(); new List<Studies>()
            {
            };
        }

        private List<Studies> GetStudies()
        {
            return new List<Studies>()
            {
                new Studies { Name = "", Value = 0, Comment = "" }
            };
        }

        public async Task<bool> AddItemAsync(Studies item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Studies item)
        {
            var oldItem = items.Where((Studies arg) => arg.Name == item.Name).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Studies arg) => arg.Name == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Studies> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Name == id));
        }

        public async Task<IEnumerable<Studies>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
