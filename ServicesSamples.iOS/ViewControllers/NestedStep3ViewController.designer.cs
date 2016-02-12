// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS.ViewControllers
{
	[Register ("NestedStep3ViewController")]
	partial class NestedStep3ViewController
	{
		[Outlet]
		UIKit.UILabel StatusLabel { get; set; }

		[Outlet]
		UIKit.UITextField ConfirmEmailTextField { get; set; }

		[Outlet]
		UIKit.UISwitch IsAgreeSwitch { get; set; }

		[Outlet]
		UIKit.UIButton FinishButton { get; set; }

		[Outlet]
		UIKit.UIButton CancelButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (StatusLabel != null) {
				StatusLabel.Dispose ();
				StatusLabel = null;
			}

			if (ConfirmEmailTextField != null) {
				ConfirmEmailTextField.Dispose ();
				ConfirmEmailTextField = null;
			}

			if (IsAgreeSwitch != null) {
				IsAgreeSwitch.Dispose ();
				IsAgreeSwitch = null;
			}

			if (FinishButton != null) {
				FinishButton.Dispose ();
				FinishButton = null;
			}

			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}
		}
	}
}
