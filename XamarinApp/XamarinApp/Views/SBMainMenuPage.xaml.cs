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
    public partial class SBMainMenuPage : ContentPage
    {
        bool _istapped = false;

        public SBMainMenuPage()
        {
            InitializeComponent();
        }

        private async void Login_ClickedAsync(object sender, EventArgs e)
        {
            if (_istapped)
                return;

            _istapped = true;

            var loginPage = new SBLoginPage();

            await Navigation.PushAsync(loginPage);

            _istapped = false;
        }

        private async void SignUp_ClickedAsync(object sender, EventArgs e)
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