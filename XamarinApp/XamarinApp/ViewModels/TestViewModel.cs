using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace XamarinApp.ViewModels
{
    public class TestViewModel : BaseViewModel
    {
        public TestViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }
        public ICommand OpenWebCommand { get; }
    }
}
