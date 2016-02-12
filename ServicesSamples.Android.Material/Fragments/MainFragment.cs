using System;
using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(NavigationBindingProvider))]
    public class MainFragment : RecyclerViewFragment<RootNavigationViewModel>
    {
        #region Constructors

        public MainFragment()
        {
        }

        public MainFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.InteractionMode = ListViewInteraction.Navigation;
            this.IconId = Resource.Drawable.ic_toolbar;
        }

        #endregion
    }
}