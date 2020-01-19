using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TestBD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomeViewPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=01e78b30-5ad8-474a-b56b-23d2c51be0b8;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
