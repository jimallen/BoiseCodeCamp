using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MyExternalClassLibrary;
using MyExternalClassLibrary.BL;

namespace BoiseCodeCamp_Android
{
    [Activity(Label = "BoiseCodeCamp_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            Task t = new Task();
            t.ID = 1;
            t.Name = "Test Task";
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

