﻿using System;
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

        private async void Btn_Registro(object sender, EventArgs e)
        {
            await DisplayAlert("Resgitro", "Haz sido registrado correctamente", "Ok" + Navigation.PushAsync(new MainPage()));
        }
    }
}