using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(AboutBindingProvider))]
	public class BindingModeFragment : Fragment<AboutViewModel>
    {
		#region Constructors

		public BindingModeFragment ()
		{
		}

		public BindingModeFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}
			
		#endregion

        #region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.AboutView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "About";
			this.IconId = Resource.Drawable.Icon;

			this.Appearance.Padding = new Thickness (16);
		}

		#endregion
    }
}