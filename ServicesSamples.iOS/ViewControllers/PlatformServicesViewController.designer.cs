// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("PlatformServicesViewController")]
	partial class PlatformServicesViewController
	{
		[Outlet]
		UIKit.UIButton RunUIButton { get; set; }

		[Outlet]
		UIKit.UIButton RunBackgroundButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (RunUIButton != null) {
				RunUIButton.Dispose ();
				RunUIButton = null;
			}

			if (RunBackgroundButton != null) {
				RunBackgroundButton.Dispose ();
				RunBackgroundButton = null;
			}
		}
	}
}
