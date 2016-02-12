// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS.ViewControllers
{
    [Register ("NavigationParameterViewController")]
    partial class NavigationParameterViewController
	{
		[Outlet]
		UIKit.UILabel StatusLabel { get; set; }

		[Outlet]
	    UIKit.UIButton CloseButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (StatusLabel != null) {
				StatusLabel.Dispose ();
				StatusLabel = null;
			}

			if (CloseButton != null) {
				CloseButton.Dispose ();
				CloseButton = null;
			}
		}
	}
}
