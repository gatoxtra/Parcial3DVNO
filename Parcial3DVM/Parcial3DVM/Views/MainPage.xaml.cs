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
    public partial class mainPage : ContentPage
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void Btn_Form_ResgistroJuego(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResgistrarJuego());
        }
        private void Btn_Form_JuegoFav(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JuegosFav());
        }
        private void Btn_Cambio_Contra(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContraCambio());
        }
    }
}