// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("TelephonyServicesViewController")]
	partial class TelephonyServicesViewController
	{
		[Outlet]
		UIKit.UITextField PhoneTextField { get; set; }

		[Outlet]
		UIKit.UIButton CallButton { get; set; }

		[Outlet]
		UIKit.UIButton MessageButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (PhoneTextField != null) {
				PhoneTextField.Dispose ();
				PhoneTextField = null;
			}

			if (CallButton != null) {
				CallButton.Dispose ();
				CallButton = null;
			}

			if (MessageButton != null) {
				MessageButton.Dispose ();
				MessageButton = null;
			}
		}
	}
}
