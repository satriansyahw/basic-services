// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("SocialServicesViewController")]
	partial class SocialServicesViewController
	{
		[Outlet]
		UIKit.UIButton ShareButton { get; set; }

		[Outlet]
		UIKit.UIButton ShareSocialButton { get; set; }

		[Outlet]
		UIKit.UIButton PostFacebookButton { get; set; }

		[Outlet]
		UIKit.UIButton PostTwitterButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ShareButton != null) {
				ShareButton.Dispose ();
				ShareButton = null;
			}

			if (ShareSocialButton != null) {
				ShareSocialButton.Dispose ();
				ShareSocialButton = null;
			}

			if (PostFacebookButton != null) {
				PostFacebookButton.Dispose ();
				PostFacebookButton = null;
			}

			if (PostTwitterButton != null) {
				PostTwitterButton.Dispose ();
				PostTwitterButton = null;
			}
		}
	}
}
