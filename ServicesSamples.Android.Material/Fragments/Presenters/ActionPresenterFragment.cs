using System;
using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Android.Fragments
{
    //[Activity(Label = "Action Presenter", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Icon = "@drawable/icon")]
    [ImportBinding(typeof(ActionPresenterBindingProvider))]
    public class ActionPresenterFragment : Fragment<ActionPresenterViewModel>
    {
        #region Constructors

        public ActionPresenterFragment()
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
            get { return Resource.Layout.action_presenter_view; }
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