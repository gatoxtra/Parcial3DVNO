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
    public partial class ResgistrarJuego : ContentPage
    {
        public ResgistrarJuego()
        {
            InitializeComponent();
        }

        private void RegistroJuego_Btn(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(EntryNameJuego.Text) && !string.IsNullOrEmpty(EntryHoras.Text) && !string.IsNullOrEmpty(EntryPlataforma.Text) && !string.IsNullOrEmpty(EntryNota.Text))
            {
                DisplayAlert("Juego registrado", "su juego ha sido registrado correctamente ", "Volver al inicio");
                Navigation.PushAsync(new mainPage());
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor ingrese correctamente los datos", "Ok");
            }

          
        }
    }
}