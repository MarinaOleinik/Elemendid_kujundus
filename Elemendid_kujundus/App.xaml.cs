//using MediaManager;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid_kujundus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //CrossMediaManager.Current.Init();
            //VideoViewRenderer.Init();
            MainPage = new NavigationPage( new PhotoPage());
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
