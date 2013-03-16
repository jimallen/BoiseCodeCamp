// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace BoiseCodeCamp
{
	[Register ("DetailScreen")]
	partial class DetailScreen
	{
		[Outlet]
		MonoTouch.UIKit.UITextField txtName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtNotes { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnSave { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnDelete { get; set; }

		[Action ("CancelDelete:")]
		partial void CancelDelete (MonoTouch.Foundation.NSObject sender);

		[Action ("Save:")]
		partial void Save (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}

			if (txtNotes != null) {
				txtNotes.Dispose ();
				txtNotes = null;
			}

			if (btnSave != null) {
				btnSave.Dispose ();
				btnSave = null;
			}

			if (btnDelete != null) {
				btnDelete.Dispose ();
				btnDelete = null;
			}
		}
	}
}
