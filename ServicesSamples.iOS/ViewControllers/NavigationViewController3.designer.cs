// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS.ViewControllers
{
	[Register ("NavigationViewController3")]
	partial class NavigationViewController3
	{
		[Outlet]
		UIKit.UILabel StatusLabel { get; set; }

		[Outlet]
		UIKit.UITextField MessageTextField { get; set; }

		[Outlet]
		UIKit.UIButton OKButton { get; set; }

		[Outlet]
		UIKit.UIButton CancelButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (StatusLabel != null) {
				StatusLabel.Dispose ();
				StatusLabel = null;
			}

			if (MessageTextField != null) {
				MessageTextField.Dispose ();
				MessageTextField = null;
			}

			if (OKButton != null) {
				OKButton.Dispose ();
				OKButton = null;
			}

			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}
		}
	}
}
