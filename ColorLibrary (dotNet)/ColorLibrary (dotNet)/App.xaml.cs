using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ColorLibrary__dotNet_.Services;
using ColorLibrary__dotNet_.Views;
using ColorLibrary__dotNet_.Data;

namespace ColorLibrary__dotNet_
{
    public partial class App : Application
    {

        static ColorDatabase database;
        public static ColorDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ColorDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Colors.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
    }
}
