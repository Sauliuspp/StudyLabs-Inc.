﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SBForumsPage : ContentPage
    {
        public string username { get; set; }
        public string password { get; set; }

        public SBForumsPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private async void ViewThreads_ClickedAsync(object sender, EventArgs e)
        {
            var threadsPage = new SBThreadListPage(username, password, Studies.Text);
            await Navigation.PushAsync(threadsPage);
        }
    }
}