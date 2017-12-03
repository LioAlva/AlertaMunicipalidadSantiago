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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.SetGeolocation(
                ////mainViewModel.CurrentCustomer.FullName,
                //mainViewModel.CurrentCustomer.Address,
                //mainViewModel.CurrentCustomer.Latitude,
                //mainViewModel.CurrentCustomer.Longitude
                );
            //List<Pin> Pins = new List<Pin>();
            //var position1 = new Position(6.2652880, -75.5098530);
            //var pin1 = new Pin
            //{
            //    Type = PinType.Place,
            //    Position = position1,
            //    Label = "Pin1",
            //    Address = "prueba pin1"
            //};
            //Pins.Add(pin1);

            //var position2 = new Position(6.2652880, -75.4598530);
            //var pin2 = new Pin
            //{
            //    Type = PinType.Place,
            //    Position = position2,
            //    Label = "Pin2",
            //    Address = "prueba pin2"
            //};
            //Pins.Add(pin2);

            //var position3 = new Position(6.2652880, -75.4898530);
            //var pin3 = new Pin
            //{
            //    Type = PinType.Place,
            //    Position = position3,
            //    Label = "Pin3",
            //    Address = "prueba pin3"
            //};
            //Pins.Add(pin3);
            foreach (Pin item in mainViewModel.Pins)

            //foreach (Pin item in Pins)
            {
                MyMap.Pins.Add(item);
            }
            Locator();
        }

        private async void Locator()
        {
            try
            {
                var locator = CrossGeolocator.Current;

                if (locator.IsGeolocationAvailable && locator.IsGeolocationEnabled)
                {
                    locator.DesiredAccuracy = 50;

                    //var location = await locator.GetPositionAsync(timeoutMilliseconds: 10000);
                    var location = await locator.GetPositionAsync();
                    var position = new Position(location.Latitude, location.Longitude);
                    MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(.3)));
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }


        }
    }
}