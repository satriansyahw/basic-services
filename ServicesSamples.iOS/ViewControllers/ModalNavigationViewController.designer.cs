// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("ModalNavigationViewController")]
	partial class ModalNavigationViewController
	{
		[Outlet]
		UIKit.UIButton NavigateModalButton { get; set; }

		[Outlet]
		UIKit.UIButton SlideButton { get; set; }

		[Outlet]
		UIKit.UIButton FlipButton { get; set; }

		[Outlet]
		UIKit.UIButton FadeButton { get; set; }

		[Outlet]
		UIKit.UIButton CurlButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NavigateModalButton != null) {
				NavigateModalButton.Dispose ();
				NavigateModalButton = null;
			}

			if (SlideButton != null) {
				SlideButton.Dispose ();
				SlideButton = null;
			}

			if (FlipButton != null) {
				FlipButton.Dispose ();
				FlipButton = null;
			}

			if (FadeButton != null) {
				FadeButton.Dispose ();
				FadeButton = null;
			}

			if (CurlButton != null) {
				CurlButton.Dispose ();
				CurlButton = null;
			}
		}
	}
}
