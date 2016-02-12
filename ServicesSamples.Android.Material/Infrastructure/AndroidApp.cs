using System;
using Android.App;
using Android.Runtime;
using Intersoft.Crosslight.Android;

namespace ServicesSamples.Android.Infrastructure
{
    [Application]
    public class AndroidApp : AndroidApplication
    {
        #region Constructors

        public AndroidApp(IntPtr intPtr, JniHandleOwnership jniHandleOwnership)
            : base(intPtr, jniHandleOwnership)
        {
        }

        #endregion
    }
}