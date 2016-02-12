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
    //[Activity(Label = "Toast Presenter", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Icon = "@drawable/icon")]
    [ImportBinding(typeof(ToastPresenterBindingProvider))]
	public class ToastPresenterFragment : Fragment<ToastPresenterViewModel>
    {
		#region Constructors

		public ToastPresenterFragment ()
		{
		}

		public ToastPresenterFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.ToastPresenterView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Platform Services";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}