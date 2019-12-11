using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Models;
using XamarinApp.Services;

namespace XamarinApp.ViewModels
{
    public class ThreadsViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<ForumThread> ForumThreads { get; set; }
        public Command LoadItemsCommand { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public ThreadsViewModel(string studies)
        {
            ForumThreads = new ObservableCollection<ForumThread>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand(studies));
        }

        async Task ExecuteLoadItemsCommand(string studies)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                ForumThreads.Clear();
                ThreadsDataStore dataStore = new ThreadsDataStore(studies);
                var items = await dataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    ForumThreads.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}