using System;
using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Android.Fragments
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
            get { return Resource.Layout.basic_navigation_view; }
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.AddBarItem(new BarItem("NavigateBarItem", "Navigater"));
            this.IconId = Resource.Drawable.ic_toolbar;
        }

        #endregion
    }
}