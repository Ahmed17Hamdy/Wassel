using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WasselApp.Helpers
{
   public class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        private const string LongitudeKey = "LongitudeKey_key";
        private static readonly double LongitudeKeyDefault = 0;
        public static double LongitudeKeySettings
        {
            get => AppSettings.GetValueOrDefault(LongitudeKey, LongitudeKeyDefault);
            set => AppSettings.AddOrUpdateValue(LongitudeKey, value);
        }
        private const string LaititudeKey = "LatitudeKey_key";
        private static readonly double LaititudeKeyDefault = 0;
        public static double LaititudeKeySettings
        {
            get => AppSettings.GetValueOrDefault(LaititudeKey, LaititudeKeyDefault);
            set => AppSettings.AddOrUpdateValue(LaititudeKey, value);
        }

    }
}
