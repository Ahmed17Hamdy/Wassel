

namespace WasselApp.iOS
{

    using Foundation;
    using UIKit;
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Rg.Plugins.Popup.Popup.Init();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            Xamarin.FormsGoogleMaps.Init("AIzaSyD0vVJKAQz1OTMTxzvXEEyFFtiEKlpLwZI");
            return base.FinishedLaunching(app, options);
        }
    }
}
