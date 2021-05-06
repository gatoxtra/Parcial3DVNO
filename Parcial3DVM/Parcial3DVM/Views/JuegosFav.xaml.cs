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
    public partial class JuegosFav : ContentPage
    {
        public JuegosFav()
        {
            InitializeComponent();
        }
        private void Btn_JuegoFav_Res(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EntryJuegoFav.Text))
            {
                DisplayAlert("Favorito", "Juevo favorito añadido", "Volver al inicio");
                Navigation.PushAsync(new mainPage());
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor ingrese correctamente los datos", "Ok");
            }
        }
    }
}