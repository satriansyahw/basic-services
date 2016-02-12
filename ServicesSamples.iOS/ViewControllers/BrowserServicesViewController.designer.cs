// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("BrowserServicesViewController")]
	partial class BrowserServicesViewController
	{
		[Outlet]
		UIKit.UIButton OpenBrowserButton { get; set; }

		[Outlet]
		UIKit.UIButton ComposeMailButton { get; set; }

		[Outlet]
		UIKit.UIButton ComposeMailAdvancedButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (OpenBrowserButton != null) {
				OpenBrowserButton.Dispose ();
				OpenBrowserButton = null;
			}

			if (ComposeMailButton != null) {
				ComposeMailButton.Dispose ();
				ComposeMailButton = null;
			}

			if (ComposeMailAdvancedButton != null) {
				ComposeMailAdvancedButton.Dispose ();
				ComposeMailAdvancedButton = null;
			}
		}
	}
}
