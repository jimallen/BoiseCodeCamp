// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace BoiseCodeCamp
{
	[Register ("TaskViewController")]
	partial class TaskViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITableView MyTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MyTableView != null) {
				MyTableView.Dispose ();
				MyTableView = null;
			}
		}
	}
}
