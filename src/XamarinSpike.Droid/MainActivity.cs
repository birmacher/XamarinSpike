﻿namespace XamarinSpike.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    [ Activity( Label = "XamarinSpike", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation ) ]
    public class MainActivity: FormsApplicationActivity
    {
        protected override void OnCreate( Bundle bundle )
        {
            base.OnCreate( bundle );

            Forms.Init( this, bundle );
            LoadApplication( new App() );
        }
    }
}
