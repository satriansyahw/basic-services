using System;
using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Android.Fragments
{
    [ImportBinding(typeof(AboutBindingProvider))]
    public class BindingModeFragment : Fragment<AboutViewModel>
    {
        #region Constructors

        public BindingModeFragment()
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
            get { return Resource.Layout.about_view; }
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.IconId = Resource.Drawable.ic_toolbar;
            this.Appearance.Padding = new Thickness(16);
        }

        #endregion
    }
}