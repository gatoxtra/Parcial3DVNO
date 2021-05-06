using Parcial3DVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial3DVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
        }
        private async void NavigateBTN_Oncliked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new RegistroPage()));
        }

    }
}