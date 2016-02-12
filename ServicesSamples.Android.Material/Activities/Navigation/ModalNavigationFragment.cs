using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ModalNavigationBindingProvider))]
	public class ModalNavigationFragment : Fragment<ModalNavigationViewModel>
    {
		#region Constructors

		public ModalNavigationFragment ()
		{
		}

		public ModalNavigationFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.ModalNavigationView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Modal Navigation";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}