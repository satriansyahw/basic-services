using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(BasicNavigationBindingProvider))]
    public class BasicNavigationFragment : Fragment<BasicNavigationViewModel>
	{
		#region Constructors

		public BasicNavigationFragment()
		{
		}

		public BasicNavigationFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

        #region Properties

		protected override int ContentLayoutId 
		{
			get { return Resource.Layout.BasicNavigationView; }
		}

        protected override int MenuLayoutId
        {
            get { return Resource.Layout.BasicNavigationActionBarLayout; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Basic Navigation";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}