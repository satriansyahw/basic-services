// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
	[Register ("NotificationServicesViewController")]
	partial class NotificationServicesViewController
	{
		[Outlet]
		UIKit.UIButton GetCurrentConnectionButton { get; set; }

		[Outlet]
		UIKit.UIButton GetReachabilityButton { get; set; }

		[Outlet]
		UIKit.UIButton MonitorConnectionButton { get; set; }

		[Outlet]
		UIKit.UIButton ScheduleNotificationButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (GetCurrentConnectionButton != null) {
				GetCurrentConnectionButton.Dispose ();
				GetCurrentConnectionButton = null;
			}

			if (GetReachabilityButton != null) {
				GetReachabilityButton.Dispose ();
				GetReachabilityButton = null;
			}

			if (MonitorConnectionButton != null) {
				MonitorConnectionButton.Dispose ();
				MonitorConnectionButton = null;
			}

			if (ScheduleNotificationButton != null) {
				ScheduleNotificationButton.Dispose ();
				ScheduleNotificationButton = null;
			}
		}
	}
}
