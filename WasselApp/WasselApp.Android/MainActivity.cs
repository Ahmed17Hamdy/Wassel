
namespace WasselApp.Droid
{
    using Android;
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using Android.Runtime;
    using Android.Widget;
    using System;
    using System.Threading.Tasks;
    using Xamarin.Forms.GoogleMaps.Android;

    [Activity(Label = "WasselApp",
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        readonly string[] permission =
            {
            Android.Manifest.Permission.AccessCheckinProperties,
            Android.Manifest.Permission.AccessFineLocation,
            Android.Manifest.Permission.Internet
            };
        const int RequestId = 0;
        protected  override void OnCreate(Bundle savedInstanceState)
        {
            //await TryToGetPermissions();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
           
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            //RequestPermissions(permission, RequestId);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            var platformConfig = new PlatformConfig
            {
                BitmapDescriptorFactory = new CachingNativeBitmapDescriptorFactory()
            };
            Xamarin.FormsGoogleMaps.Init(this, savedInstanceState , platformConfig);
            LoadApplication(new App());

        }

        

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permission, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }







    }
}