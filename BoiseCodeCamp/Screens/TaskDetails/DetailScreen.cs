
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ExternalLibrary.BL;

namespace BoiseCodeCamp
{
	public partial class DetailScreen : UIViewController
	{
		protected Task _task;
		public DetailScreen (Task task) : base ("DetailScreen", null)
		{
			this._task = task;
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

			// set the cancel delete based on whether or not it's an existing task
			this.btnDelete.SetTitle((this._task.ID == 0 ? "Cancel" : "Delete"), UIControlState.Normal);
			
			this.txtName.Text = this._task.Name;
			this.txtNotes.Text = this._task.Notes;
			

			
			this.txtName.ReturnKeyType = UIReturnKeyType.Next;
			this.txtName.ShouldReturn += (t) => { this.txtNotes.BecomeFirstResponder(); return true; };
			
			this.txtNotes.ReturnKeyType = UIReturnKeyType.Done;
			this.txtName.ShouldReturn += (t) => { this.txtNotes.ResignFirstResponder(); return true; };
		}

		partial void CancelDelete (NSObject sender)
		{
			if(this._task.ID != 0)
			{
				ExternalLibrary.BL.Managers.TaskManager.DeleteTask(this._task.ID);
			}
			
			this.NavigationController.PopViewControllerAnimated(true);
		} 

		partial void Save (NSObject sender)
		{
			this._task.Name = this.txtName.Text;
			this._task.Notes = this.txtNotes.Text;
			ExternalLibrary.BL.Managers.TaskManager.SaveTask(this._task);
			this.NavigationController.PopViewControllerAnimated(true);
		}
	}
}

