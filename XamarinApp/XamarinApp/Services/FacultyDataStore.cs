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
                new Faculty { Name = Faculties._0, Value = 0, Comment = "" },
                new Faculty { Name = Faculties._1, Value = 1, Comment = "" },
                new Faculty { Name = Faculties._2, Value = 2, Comment = "" },
                new Faculty { Name = Faculties._3, Value = 3, Comment = "" },
                new Faculty { Name = Faculties._4, Value = 4, Comment = "" },
                new Faculty { Name = Faculties._5, Value = 5, Comment = "" },
                new Faculty { Name = Faculties._6, Value = 6, Comment = "" },
                new Faculty { Name = Faculties._7, Value = 7, Comment = "" },
                new Faculty { Name = Faculties._8, Value = 8, Comment = "" },
                new Faculty { Name = Faculties._9, Value = 9, Comment = "" },
                new Faculty { Name = Faculties._10, Value = 10, Comment = "" },
                new Faculty { Name = Faculties._11, Value = 11, Comment = "" },
                new Faculty { Name = Faculties._12, Value = 12, Comment = "" },
                new Faculty { Name = Faculties._13, Value = 13, Comment = "" }
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
