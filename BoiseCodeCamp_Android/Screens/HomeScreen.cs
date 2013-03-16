using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using ExternalLibrary.BL;
using ExternalLibrary.BL.Managers;

namespace BoiseCodeCamp_Android.Screens
{
	[Activity (Label = "BoiseCodeCamp_Android", MainLauncher = true)]			
	public class HomeScreen : Activity
	{
		protected Adapters.TaskListAdapter _taskList;
		protected IList<Task> _tasks;
		protected Button _addTaskButton = null;
		protected ListView _taskListView = null;
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			
			// set our layout to be the home screen
			this.SetContentView(Resource.Layout.HomeScreen);

			//Find our controls
			this._taskListView = FindViewById<ListView> (Resource.Id.lstTasks);
			this._addTaskButton = FindViewById<Button> (Resource.Id.btnAddTask);

			// wire up add task button handler
			if(this._addTaskButton != null)
			{
				this._addTaskButton.Click += (sender, e) => {
					this.StartActivity(typeof(TaskDetailsScreen));
				};
			}
			
			// wire up task click handler
			if(this._taskListView != null)
			{
				this._taskListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
					var taskDetails = new Intent (this, typeof (TaskDetailsScreen));
					taskDetails.PutExtra ("TaskID", this._tasks[e.Position].ID);
					this.StartActivity (taskDetails);
				};
			}
		}
		
		protected override void OnResume ()
		{
			base.OnResume ();

			this._tasks = TaskManager.GetTasks();
			
			// create our adapter
			this._taskList = new Adapters.TaskListAdapter(this, this._tasks);

			//Hook up our adapter to our ListView
			this._taskListView.Adapter = this._taskList;
		}
		
	}
}

