using Autofac;
using Healthy.ApplicationObjects;
using Healthy.BaseComponents.Interfaces;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using System;
using Xamarin.Forms;

namespace Healthy.BaseComponents.Pages
{
    public class BaseContentPage : ContentPage
    {
        readonly object _viewModel;
        public object ViewModel { get { return _viewModel; } }

        public BaseContentPage(Type viewModel)
        {
            using (var scope = AppContainer.Container.BeginLifetimeScope())
            {
                _viewModel = AppContainer.Container.Resolve(viewModel);
            }

            BindingContext = _viewModel;
        }

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
