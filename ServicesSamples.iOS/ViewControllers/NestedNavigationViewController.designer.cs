// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("NestedNavigationViewController")]
	partial class NestedNavigationViewController
	{
		[Outlet]
		UIKit.UIButton NavigateModalButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NavigateModalButton != null) {
				NavigateModalButton.Dispose ();
				NavigateModalButton = null;
			}
		}
	}
}
