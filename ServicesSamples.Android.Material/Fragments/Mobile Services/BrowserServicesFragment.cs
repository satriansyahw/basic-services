using System;
using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Android.Fragments
{
    [ImportBinding(typeof(ServicesBindingProvider))]
    public class BrowserServicesFragment : Fragment<BrowserServicesViewModel>
    {
        #region Constructors

        public BrowserServicesFragment()
        {
        }

        public BrowserServicesFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.browser_services_view; }
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.IconId = Resource.Drawable.ic_toolbar;
        }

        #endregion
    }
}