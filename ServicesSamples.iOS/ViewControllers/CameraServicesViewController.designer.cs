// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("CameraServicesViewController")]
	partial class CameraServicesViewController
	{
		[Outlet]
		UIKit.UIButton CapturePhotoButton { get; set; }

		[Outlet]
		UIKit.UIButton CaptureVideoButton { get; set; }

		[Outlet]
		UIKit.UIButton ChooseLibraryButton { get; set; }

		[Outlet]
		UIKit.UIButton PlaySoundButton { get; set; }

		[Outlet]
		UIKit.UIButton OpenYoutubeButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CapturePhotoButton != null) {
				CapturePhotoButton.Dispose ();
				CapturePhotoButton = null;
			}

			if (CaptureVideoButton != null) {
				CaptureVideoButton.Dispose ();
				CaptureVideoButton = null;
			}

			if (ChooseLibraryButton != null) {
				ChooseLibraryButton.Dispose ();
				ChooseLibraryButton = null;
			}

			if (PlaySoundButton != null) {
				PlaySoundButton.Dispose ();
				PlaySoundButton = null;
			}

			if (OpenYoutubeButton != null) {
				OpenYoutubeButton.Dispose ();
				OpenYoutubeButton = null;
			}
		}
	}
}
