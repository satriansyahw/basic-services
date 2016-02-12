using Android.App;
using Android.Content.PM;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
	[ImportBinding(typeof(ServicesBindingProvider))]
	public class LocationServicesFragment : Fragment<LocationServicesViewModel>
    {
		#region Constructors

		public LocationServicesFragment ()
		{
		}

		public LocationServicesFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.LocationServicesView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Location Services";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}