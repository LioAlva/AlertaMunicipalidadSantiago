using AlertaSantiagoApp.ViewModels;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace AlertaSantiagoApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();

            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.SetGeolocation(
                //mainViewModel.CurrentCustomer.FullName,
                //mainViewModel.CurrentCustomer.Address,
                //mainViewModel.CurrentCustomer.Latitude,
                //mainViewModel.CurrentCustomer.Longitude
                );
            foreach (Pin item in mainViewModel.Pins)
            {
                MyMap.Pins.Add(item);
            }
            Locator();
        }

        private async void Locator()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            //var location = await locator.GetPositionAsync(timeoutMilliseconds: 10000);
            var location = await locator.GetPositionAsync();
            var position = new Position(location.Latitude, location.Longitude);
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(.3)));

        } 
    }
}