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
    //[Activity(Label = "Action Presenter", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Icon = "@drawable/icon")]
    [ImportBinding(typeof(ActionPresenterBindingProvider))]
    public class ActionPresenterFragment : Fragment<ActionPresenterViewModel>
    {
		#region Constructors

		public ActionPresenterFragment ()
		{
		}

		public ActionPresenterFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

        #region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.ActionPresenterView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Action Presenter";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}