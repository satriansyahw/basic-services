using System;
using Android.App;
using Intersoft.Crosslight.Android;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [Application]
    public class AndroidApp : AndroidApplication
    {
        public AndroidApp(IntPtr intPtr, JniHandleOwnership jniHandleOwnership) 
            : base(intPtr, jniHandleOwnership)
        {
        }
    }
}

