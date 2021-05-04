using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Parcial3DVM.Services;
using Parcial3DVM.Views;

namespace Parcial3DVM
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
