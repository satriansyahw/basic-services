// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ServicesSamples.iOS
{
	[Register ("ContactServicesViewController")]
	partial class ContactServicesViewController
	{
		[Outlet]
		UIKit.UIButton CreateContactButton { get; set; }

		[Outlet]
		UIKit.UIButton DeleteContactButton { get; set; }

		[Outlet]
		UIKit.UIButton PickContactButton { get; set; }

		[Outlet]
		UIKit.UILabel SelectedContactLabel { get; set; }

		[Outlet]
		UIKit.UILabel TotalContactsLabel { get; set; }

		[Outlet]
		UIKit.UIButton UpdateContactButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CreateContactButton != null) {
				CreateContactButton.Dispose ();
				CreateContactButton = null;
			}

			if (UpdateContactButton != null) {
				UpdateContactButton.Dispose ();
				UpdateContactButton = null;
			}

			if (DeleteContactButton != null) {
				DeleteContactButton.Dispose ();
				DeleteContactButton = null;
			}

			if (PickContactButton != null) {
				PickContactButton.Dispose ();
				PickContactButton = null;
			}

			if (SelectedContactLabel != null) {
				SelectedContactLabel.Dispose ();
				SelectedContactLabel = null;
			}

			if (TotalContactsLabel != null) {
				TotalContactsLabel.Dispose ();
				TotalContactsLabel = null;
			}
		}
	}
}
