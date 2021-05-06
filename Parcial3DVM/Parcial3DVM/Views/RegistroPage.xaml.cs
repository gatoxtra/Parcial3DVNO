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
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        private void Btn_Registro(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EntryNameUser.Text) && !string.IsNullOrEmpty(EntryContraseña.Text) && !string.IsNullOrEmpty(EntryEmail.Text))
            {
                DisplayAlert("Cuenta registrada", "su cuenta ha registrado correctamente ", "inicio");
                Navigation.PushAsync(new mainPage());
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor ingrese correctamente los datos", "Ok");
            }

        }
    }
}