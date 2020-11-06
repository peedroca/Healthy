using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Healthy.ApplicationObjects;

namespace Healthy.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppContainer.Container = new Setup().CreateContainer();

            MainPage = new Views.Menu();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=0e6289b3-1afa-4598-8a08-1558df7f3682;",
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
