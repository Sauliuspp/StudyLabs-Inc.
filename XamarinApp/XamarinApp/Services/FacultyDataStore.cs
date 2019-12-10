﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    public class FacultyDataStore : IDataStore<Faculty>
    {
        readonly List<Faculty> items;

        public FacultyDataStore()
        {
            items = new List<Faculty>()
            {
                new Faculty { Name = Guid.NewGuid().ToString(), Value = "Cia", Comment = "123." },
                new Faculty { Name = Guid.NewGuid().ToString(), Value = "Yra", Comment = "456." },
                new Faculty { Name = Guid.NewGuid().ToString(), Value = "Bandymas", Comment = "789." }
            };
        }

        public async Task<bool> AddItemAsync(Faculty item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Faculty item)
        {
            var oldItem = items.Where((Faculty arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Faculty arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Faculty> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Faculty>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
