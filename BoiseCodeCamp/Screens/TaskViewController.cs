
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ExternalLibrary.BL;
using BoiseCodeCamp.AL;
using ExternalLibrary.BL.Managers;
	

namespace BoiseCodeCamp
{
	public partial class TaskViewController : UIViewController
	{

		AL.TaskTableSource _tableSource = null;
		DetailScreen _detailsScreen = null;
	 
		public TaskViewController () : base ("TaskViewController", null)
		{
			this.Initialize ();
			this.Title = "Our Task Manager";
		}

		protected void Initialize()
		{
			this.NavigationItem.SetRightBarButtonItem (new UIBarButtonItem (UIBarButtonSystemItem.Add), false);

			this.NavigationItem.RightBarButtonItem.Clicked += (sender, e) => { this.ShowTaskDetails(new Task()); };
			ResetEditMode ();


		}

		protected void EnterEditMode(){
			MyTableView.SetEditing(true, true);

			this.NavigationItem.SetLeftBarButtonItem (new UIBarButtonItem (UIBarButtonSystemItem.Done), false);
			this.NavigationItem.LeftBarButtonItem.Clicked += (sender, e) => { 
				MyTableView.SetEditing(false, true);
				ResetEditMode();
			};
		}

		protected void ResetEditMode(){

			this.NavigationItem.SetLeftBarButtonItem (new UIBarButtonItem (UIBarButtonSystemItem.Edit), false);
			this.NavigationItem.LeftBarButtonItem.Clicked += (sender, e) => { 
				
				EnterEditMode();
			};
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();



			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			
			// reload/refresh
			this.PopulateTable();			
		}

		protected void PopulateTable()
		{
			this._tableSource = new BoiseCodeCamp.AL.TaskTableSource(ExternalLibrary.BL.Managers.TaskManager.GetTasks());
			this._tableSource.TaskDeleted += (object sender, TaskClickedEventArgs e) => { this.DeleteTaskRow(e.Task.ID); };
			this._tableSource.TaskClicked += (object sender, TaskClickedEventArgs e) => { this.ShowTaskDetails(e.Task); };
			this.MyTableView.Source = this._tableSource;					
		}

		protected void DeleteTaskRow(int id)
		{
			ExternalLibrary.BL.Managers.TaskManager.DeleteTask(id);
			this.PopulateTable();
		}
		protected void ShowTaskDetails(Task task)
		{
			this._detailsScreen = new DetailScreen(task);
			this.NavigationController.PushViewController(this._detailsScreen, true);
		}

		private void ClearAll(){
			foreach (Task t in ExternalLibrary.BL.Managers.TaskManager.GetTasks()) {


				TaskManager.DeleteTask(t.ID);

			}
		}
	}
}

