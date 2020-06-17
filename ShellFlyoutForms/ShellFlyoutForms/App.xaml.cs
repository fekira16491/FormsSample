using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellFlyoutForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ShellFlyoutForms.Shell.FlyoutItem();
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
