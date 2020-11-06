using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using System;
using Xamarin.Forms;

namespace Healthy.BaseComponents.Pages
{
    public class BaseContentPage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();

            Analytics.TrackEvent($"{GetType().Name} Appeared");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Analytics.TrackEvent($"{GetType().Name} Disappeared");
        }
    }
}
