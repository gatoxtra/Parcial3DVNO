using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial3DVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContraCambio : ContentPage
    {
        public ContraCambio()
        {
            InitializeComponent();
        }
        private void Btn_CambioContra(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ContraNueva.Text) && !string.IsNullOrEmpty(ContraR.Text))
            {
                DisplayAlert("Contraseña cambiada", "su contraseña ha sido cambiada correctamente", "Volver al inicio");
                Navigation.PushAsync(new mainPage());
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor ingrese correctamente los datos", "Ok");
            }
        }
    }
}