// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ServicesSamples.iOS
{
    [Register("AboutViewController")]
    partial class AboutViewController
    {
        [Outlet]
        UIKit.UILabel GreetingLabel { get; set; }

        [Outlet]
        UIKit.UIButton LearnMoreButton { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (GreetingLabel != null)
            {
                GreetingLabel.Dispose();
                GreetingLabel = null;
            }

            if (LearnMoreButton != null)
            {
                LearnMoreButton.Dispose();
                LearnMoreButton = null;
            }
        }
    }
}
