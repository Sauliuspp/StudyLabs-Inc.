using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SBFindBuddiesSearchPage : ContentPage
    {
        public SBFindBuddiesSearchPage()
        {
            InitializeComponent();
        }

        private async void BestStuddyBuddies_ClickedAsync(object sender, EventArgs e)
        {
            var bestStuddyBuddiesPage = new SBBestStuddyBuddiesPage();
            await Navigation.PushAsync(bestStuddyBuddiesPage);
        }
    }
}