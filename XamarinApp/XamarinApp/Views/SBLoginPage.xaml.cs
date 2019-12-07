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
    public partial class SBLoginPage : ContentPage
    {
        bool _istapped = false;

        public SBLoginPage()
        {
            InitializeComponent();
        }

        private async void EnterForums_ClickedAsync(object sender, EventArgs e)
        {
            if (_istapped)
                return;

            _istapped = true;

            var newPage = new ItemsPage();
            await Navigation.PushAsync(newPage);

            _istapped = false;
        }
    }
}