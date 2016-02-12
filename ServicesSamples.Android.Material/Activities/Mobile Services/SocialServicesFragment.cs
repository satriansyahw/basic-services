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
	public class SocialServicesFragment : Fragment<SocialServicesViewModel>
    {
		#region Constructors

		public SocialServicesFragment ()
		{
		}
			
		public SocialServicesFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.SocialServicesView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Social Services";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}