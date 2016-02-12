using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ViewModel3BindingProvider))]
	public class NavigationFragment3 : Fragment<ViewModel3>
    {
        #region Constructors

		public NavigationFragment3()
        {
        }
			
		public NavigationFragment3(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}
			
        #endregion

		#region Properties

		protected override int ContentLayoutId 
		{
			get { return Resource.Layout.ModalNavigationContentView; }
		}

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Modal Navigation Activity";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}