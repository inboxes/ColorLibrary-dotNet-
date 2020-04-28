using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ColorLibrary__dotNet_.Services;
using ColorLibrary__dotNet_.Views;

namespace ColorLibrary__dotNet_
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
