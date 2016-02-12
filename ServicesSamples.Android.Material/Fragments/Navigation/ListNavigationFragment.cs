using System;
using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Android.Fragments
{
    [ImportBinding(typeof(ListNavigationBindingProvider))]
    public class ListNavigationFragment : RecyclerViewFragment<SimpleListViewModel>
    {
        #region Constructors

        public ListNavigationFragment()
        {
        }

        public ListNavigationFragment(IntPtr javaReference, JniHandleOwnership transfer)
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