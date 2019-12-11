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
    public partial class SBViewStatisticsPage : ContentPage
    {
        public string username { get; set; }
        public string password { get; set; }

        public SBViewStatisticsPage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void YourStatistics_Clicked(object sender, EventArgs e)
        {

        }
    }
}