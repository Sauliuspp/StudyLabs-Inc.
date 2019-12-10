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
    public partial class SBEditAccountPage : ContentPage
    {
        public string username { get; set;}
        public string password { get; set; }

        public SBEditAccountPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private async void ChangePassword_ClickedAsync(object sender, EventArgs e)
        {
            var changePasswordPage = new ChangePasswordPage(username, password);
            await Navigation.PushAsync(changePasswordPage);
        }

        private async void DeleteAccount_ClickedAsync(object sender, EventArgs e)
        {
            var deleteAccountPage = new DeleteAccountPage(username, password);
            await Navigation.PushAsync(deleteAccountPage);
        }
    }
}