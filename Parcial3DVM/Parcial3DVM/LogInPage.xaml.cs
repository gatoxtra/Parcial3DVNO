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

        private void NavigateBTN_Cliked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usuario.Text) && !string.IsNullOrEmpty(ContraUsuario.Text))
            {
                
                Navigation.PushAsync(new NavigationPage(new mainPage()));
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor ingrese correctamente los datos", "Ok");
            }
        }
        
    }
}