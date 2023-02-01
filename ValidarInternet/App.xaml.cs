using System;
using ValidarInternet.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ValidarInternet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
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
