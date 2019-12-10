using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    public class FacultyDataStore : IDataStore<Faculty>
    {
        readonly List<Faculty> items;

        public FacultyDataStore()
        {
            items = GetFaculties();
        }

        private List<Faculty> GetFaculties()
        {
            return new List<Faculty>()
            {
                
            };
        }

        public async Task<bool> AddItemAsync(Faculty item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Faculty item)
        {
            var oldItem = items.Where((Faculty arg) => arg.Name == item.Name).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Faculty arg) => arg.Name == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Faculty> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Name == id));
        }

        public async Task<IEnumerable<Faculty>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
