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
    //[Activity(Label = "Activity Presenter", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Icon = "@drawable/icon")]
    [ImportBinding(typeof(ActivityPresenterBindingProvider))]
    public class ActivityPresenterFragment : Fragment<ActivityPresenterViewModel>
    {
		#region Constructors

		public ActivityPresenterFragment ()
		{
		}

		public ActivityPresenterFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.ActivityPresenterView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Activity Presenter";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}