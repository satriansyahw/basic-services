// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("PhotoDetailViewController")]
	partial class PhotoDetailViewController
	{
		[Outlet]
		UIKit.UIButton CloseButton { get; set; }

		[Outlet]
		UIKit.UIImageView FullSizeImageView { get; set; }

		[Outlet]
		UIKit.UILabel FullSizeLabel { get; set; }

		[Outlet]
		UIKit.UIImageView ThumbnailImageView { get; set; }

		[Outlet]
		UIKit.UILabel ThumbnailSizeLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FullSizeLabel != null) {
				FullSizeLabel.Dispose ();
				FullSizeLabel = null;
			}

			if (FullSizeImageView != null) {
				FullSizeImageView.Dispose ();
				FullSizeImageView = null;
			}

			if (ThumbnailSizeLabel != null) {
				ThumbnailSizeLabel.Dispose ();
				ThumbnailSizeLabel = null;
			}

			if (ThumbnailImageView != null) {
				ThumbnailImageView.Dispose ();
				ThumbnailImageView = null;
			}

			if (CloseButton != null) {
				CloseButton.Dispose ();
				CloseButton = null;
			}
		}
	}
}
