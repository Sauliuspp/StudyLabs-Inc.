﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Models;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SBAuthentifiedPage : ContentPage
    {
        public string username { get; set; }
        public string password { get; set; }
        public SBAuthentifiedPage(AStuddyBuddy buddy)
        {
            InitializeComponent();
            username = buddy.Nickname;
            password = buddy.Password;
        }

        private async void EnterForums_ClickedAsync(object sender, EventArgs e)
        {
            var forumsPage = new SBForumsPage(username, password);
            await Navigation.PushAsync(forumsPage);
        }

        private async void FindBestBuddies_ClickedAsync(object sender, EventArgs e)
        {
            var findBuddiesSearchPage = new SBFindBuddiesSearchPage();
            await Navigation.PushAsync(findBuddiesSearchPage);
        }

        private async void EditAccount_ClickedAsync(object sender, EventArgs e)
        {
            var editAccountPage = new SBEditAccountPage(username, password);
            await Navigation.PushAsync(editAccountPage);
        }

        private async void ViewStatistics_ClickedAsync(object sender, EventArgs e)
        {
            var viewStatisticsPage = new SBViewStatisticsPage(username, password);
            await Navigation.PushAsync(viewStatisticsPage);
        }
    }
}