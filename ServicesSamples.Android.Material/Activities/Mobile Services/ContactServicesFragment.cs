using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ContactServicesBindingProvider))]
	public class ContactServicesFragment : Fragment<ContactServicesViewModel>
    {
		#region Constructors

		public ContactServicesFragment ()
		{
		}

		public ContactServicesFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

        #region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.ContactServicesView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Contact Services";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}