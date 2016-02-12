// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("BasicNavigationViewController")]
	partial class BasicNavigationViewController
	{
		[Outlet]
		UIKit.UIButton NavigateTypeButton { get; set; }

		[Outlet]
		UIKit.UIButton NavigateIdentifierButton { get; set; }

		[Outlet]
		UIKit.UITextField TextField { get; set; }

		[Outlet]
		UIKit.UIButton NavigateParameterButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NavigateTypeButton != null) {
				NavigateTypeButton.Dispose ();
				NavigateTypeButton = null;
			}

			if (NavigateIdentifierButton != null) {
				NavigateIdentifierButton.Dispose ();
				NavigateIdentifierButton = null;
			}

			if (TextField != null) {
				TextField.Dispose ();
				TextField = null;
			}

			if (NavigateParameterButton != null) {
				NavigateParameterButton.Dispose ();
				NavigateParameterButton = null;
			}
		}
	}
}
