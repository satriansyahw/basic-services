using Android.App;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
	public class ContactEditorFragment : FormFragment<ContactEditorViewModel>
    {
		#region Constructors

		public ContactEditorFragment ()
		{
		}

		public ContactEditorFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}
			
		#endregion

		#region Properties

        protected override bool ShowActionBarUpButton
        {
            get { return true; }
        }

        protected override int MenuLayoutId
        {
            get { return Resource.Layout.actionbareditinglayout; }
        }

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Edit Item";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}