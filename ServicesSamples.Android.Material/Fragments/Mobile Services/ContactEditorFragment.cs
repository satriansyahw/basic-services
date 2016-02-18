using System;
using Android.Runtime;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Android.Fragments
{
    public class ContactEditorFragment : FormFragment<ContactEditorViewModel>
    {
        #region Constructors

        public ContactEditorFragment()
        {
        }

        public ContactEditorFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();
            
            this.AddBarItem(new BarItem("SaveButton", CommandItemType.Done));
            this.IconId = Resource.Drawable.ic_toolbar;
        }

        #endregion
    }
}