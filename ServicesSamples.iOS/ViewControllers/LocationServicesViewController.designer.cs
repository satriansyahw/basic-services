// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("LocationServicesViewController")]
	partial class LocationServicesViewController
	{
		[Outlet]
		UIKit.UIButton GetMyLocationButton { get; set; }

		[Outlet]
		UIKit.UIButton ShowMyLocationButton { get; set; }

		[Outlet]
		UIKit.UIButton CheckLocationButton { get; set; }

		[Outlet]
		UIKit.UIButton ShowLocationAddressButton { get; set; }

		[Outlet]
		UIKit.UIButton ShowDirectionsButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (GetMyLocationButton != null) {
				GetMyLocationButton.Dispose ();
				GetMyLocationButton = null;
			}

			if (ShowMyLocationButton != null) {
				ShowMyLocationButton.Dispose ();
				ShowMyLocationButton = null;
			}

			if (CheckLocationButton != null) {
				CheckLocationButton.Dispose ();
				CheckLocationButton = null;
			}

			if (ShowLocationAddressButton != null) {
				ShowLocationAddressButton.Dispose ();
				ShowLocationAddressButton = null;
			}

			if (ShowDirectionsButton != null) {
				ShowDirectionsButton.Dispose ();
				ShowDirectionsButton = null;
			}
		}
	}
}
