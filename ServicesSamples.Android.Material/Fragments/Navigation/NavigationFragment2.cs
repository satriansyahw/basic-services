using System;
using Android.Runtime;
using Intersoft.Crosslight;

namespace ServicesSamples.Android.Fragments
{
    [ImportBinding(typeof(ViewModel1BindingProvider))]
    [RegisterNavigation("ViewModel1Derivative")]
    public class NavigationFragment2 : NavigationFragment1
    {
        #region Constructors

        public NavigationFragment2()
        {
        }

        public NavigationFragment2(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.IconId = Resource.Drawable.ic_toolbar;
        }

        protected override void OnViewCreated()
        {
            base.OnViewCreated();

            this.ViewModel.ToastPresenter.Show("Navigated to ViewModel1 but presented with different view.");
        }

        #endregion
    }
}