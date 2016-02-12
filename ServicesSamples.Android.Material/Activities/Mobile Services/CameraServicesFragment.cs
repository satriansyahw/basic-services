using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ServicesBindingProvider))]
    public class CameraServicesFragment : Fragment<CameraServicesViewModel>
    {
		#region Constructors

		public CameraServicesFragment ()
		{
		}

		public CameraServicesFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.CameraServicesView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Camera Services";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}