using System;
using XamApps.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new QuestionPage());
            //MainPage = new NavigationPage(new ExpanderPage());
            //MainPage = new NavigationPage(new GridSample());

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
