using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android.Activities.Mobile_Services
{
    [ImportBinding(typeof(PhotoDetailBindingProvider))]
    public class PhotoDetailFragment : Fragment<PhotoViewModel>
    {
        #region Constructors

		public PhotoDetailFragment()
        {
        }
			
		public PhotoDetailFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}
			
        #endregion

		#region Properties

		protected override int ContentLayoutId
		{
			get { return Resource.Layout.PhotoDetailLayout; }
		}

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Photo Detail";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}