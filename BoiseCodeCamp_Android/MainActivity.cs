using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Tasky.BL;
using Tasky.BL.Managers;
using System.Collections.Generic;

namespace BoiseCodeCamp_Android
{
	[Activity (Label = "BoiseCodeCamp_Android", MainLauncher = true)]
	public class Activity1 : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
//			base.OnCreate (bundle);
//
//			// Set our view from the "main" layout resource
//			SetContentView (Resource.Layout.Main);
//
//			// Get our button from the layout resource,
//			// and attach an event to it
//			Button button = FindViewById<Button> (Resource.Id.myButton);
//
//			button.Click += delegate {
//				Task t = new Task (){Name = "Name", Notes = "This is a note...", DueDate = DateTime.Now.AddDays(1)};
//				int id = TaskManager.SaveTask (t);
//				IList<Task> taskd = TaskManager.GetTasks();
//				button.Text = string.Format ("{0} clicks! Number Of tasks = {1}", count++, taskd.Count);
//			};
		}
	}
}


