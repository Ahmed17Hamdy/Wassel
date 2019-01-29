
using Plugin.ExternalMaps;
using Plugin.Geolocator;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasselApp.PopUps;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace WasselApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarsPage : ContentPage
    {
        public CarsPage()
        {

            InitializeComponent();
            var Latitude = WasselApp.Helpers.Settings.LaititudeKeySettings;
            var Longitude = WasselApp.Helpers.Settings.LongitudeKeySettings;

            Position po = new Position(Latitude, Longitude);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = po ,
                Label = "مكان رقم 1",
                Address = "عنوان رقم 1",

            };
            MyMap.Pins.Add(pin);


            //MyMap.Pins = new List<CustomPin> { pin };

        }
        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;

            var Position = await locator.GetPositionAsync();
            latit.Text = Position.Latitude.ToString();
            longitude.Text = Position.Longitude.ToString();

        }

        private  void MyMap_MapClicked(object sender, Xamarin.Forms.GoogleMaps.MapClickedEventArgs e)
        {
           

            Helpers.Settings.LaititudeKeySettings = e.Point.Latitude;
            Helpers.Settings.LongitudeKeySettings = e.Point.Latitude;
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = e.Point,
                Label = "مكان رقم 1",
                Address = "عنوان رقم 1",

            };
            MyMap.Pins.Add(pin);


        }

        private async void MyMap_PinClicked(object sender, PinClickedEventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new Map1());
        }
    }
} 