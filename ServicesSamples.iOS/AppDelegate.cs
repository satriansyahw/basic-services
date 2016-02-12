using Foundation;
using UIKit;
using IntersoftCore = Intersoft.Crosslight.iOS;

namespace ServicesSamples.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : IntersoftCore.UIApplicationDelegate
    {
        #region Methods

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // iOS 8+ now requires user notification settings for local notification to work

            var settings = UIUserNotificationSettings.GetSettingsForTypes(UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound, null);
            application.RegisterUserNotificationSettings(settings);

            return base.FinishedLaunching(application, launchOptions);
        }

        protected override UIViewController WrapRootViewController(UIViewController contentViewController)
        {
            if (contentViewController is UISplitViewController || contentViewController is UITabBarController)
                return contentViewController;

            return new UINavigationController(contentViewController);
        }

        #endregion
    }
}