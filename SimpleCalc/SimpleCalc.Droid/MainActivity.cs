using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using Xamarin;
using HockeyApp.Android.Metrics;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace SimpleCalc.Droid
{
    [Activity(Label = "SimpleCalc", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            MetricsManager.Register(this, Application, "f659d1cbed754582b0c5702cda42dda4");
            //CheckForUpdates();
            Insights.Initialize("a1c53869fb2951de71e9b89acbeca5731c8415db", Application.Context);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            CrashManager.Register(this);
            MobileCenter.Start("5632dc3b-2bf0-4305-9109-3e88c58ca739", typeof(Analytics), typeof(Crashes));

        }
        void CheckForUpdates()
        {
            // Remove this for store builds!
            UpdateManager.Register(this, "f659d1cbed754582b0c5702cda42dda4");
        }
        void UnregisterManagers()
        {
            UpdateManager.Unregister();
        }

        protected override void OnPause()
        {
            base.OnPause();

            UnregisterManagers();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            UnregisterManagers();
        }
    }
}

