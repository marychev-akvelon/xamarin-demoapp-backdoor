﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Interop;

// using Microsoft.AppCenter;
// using Microsoft.AppCenter.Analytics;
// using Microsoft.AppCenter.Crashes;


namespace backdoor.Droid
{
    [Activity (Label = "backdoor.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            // AppCenter.Start("ccf240b2-e6e3-4f59-b3fb-706bb7fa66ed", typeof(Analytics), typeof(Crashes));

            global::Xamarin.Forms.Forms.Init (this, bundle);

            LoadApplication (new App ());
        }

        [Export("BackdoorMethod")]
        public string BackdoorMethod(string backdoorId)
        {
            Console.WriteLine(backdoorId);
            return "Executed Backdoor on Android";
        }
    }
}

