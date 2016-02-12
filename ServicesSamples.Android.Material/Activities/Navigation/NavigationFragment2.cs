using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ViewModel1BindingProvider))]
    [RegisterNavigation("ViewModel1Derivative")]
	public class NavigationFragment2 : NavigationFragment1
    {
		#region Constructors

		public NavigationFragment2 ()
		{
		}

		public NavigationFragment2(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

        #region Methods

        protected override void OnViewCreated()
        {
            base.OnViewCreated();

            this.ViewModel.ToastPresenter.Show("Navigated to ViewModel1 but presented with different view.");
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Navigation Activity with Identifier";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}