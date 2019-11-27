using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestViewModel : ContentPage
    {
        public TestViewModel()
        {
            InitializeComponent();
        }
    }
}