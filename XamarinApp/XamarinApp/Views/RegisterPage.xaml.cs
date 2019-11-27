using System;
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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            AStuddyBuddy buddy = new AStuddyBuddy(nickEntry.Text, linkEntry.Text, facEntry.Text, studEntry.Text);
            string nSTR = "Name: " + buddy.Nickname + "\nLink: " + buddy.Link + "\nStudies: " + buddy.Studies + "\nFaculty: " + buddy.Faculty;
            DisplayAlert("Buddy Info", nSTR, "OK");
        }
    }
}