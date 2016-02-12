// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("ActivityPresenterViewController")]
	partial class ActivityPresenterViewController
	{
		[Outlet]
		UIKit.UIButton ShowButton { get; set; }

		[Outlet]
		UIKit.UIButton ShowButton2 { get; set; }

		[Outlet]
		UIKit.UIButton ShowButton3 { get; set; }

		[Outlet]
		UIKit.UIButton ShowButton4 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ShowButton != null) {
				ShowButton.Dispose ();
				ShowButton = null;
			}

			if (ShowButton2 != null) {
				ShowButton2.Dispose ();
				ShowButton2 = null;
			}

			if (ShowButton3 != null) {
				ShowButton3.Dispose ();
				ShowButton3 = null;
			}

			if (ShowButton4 != null) {
				ShowButton4.Dispose ();
				ShowButton4 = null;
			}
		}
	}
}
