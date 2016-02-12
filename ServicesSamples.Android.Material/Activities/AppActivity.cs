using System;
using Android.App;
using Android.Runtime;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Android.Activities
{
    [Activity]
    public class AppActivity : AppCompatActivity<RootNavigationViewModel>
    {
        #region Constructors

        public AppActivity()
        {
        }

        public AppActivity(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion
    }
}