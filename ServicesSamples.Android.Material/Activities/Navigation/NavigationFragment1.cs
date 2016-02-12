using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ViewModel1BindingProvider))]
	public class NavigationFragment1 : Fragment<ViewModel1>
    {
        #region Constructors

		public NavigationFragment1()
        {
        }
			
		public NavigationFragment1(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

		protected override int ContentLayoutId 
		{
			get { return Resource.Layout.NavigationContentView; }
		}

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Navigation Activity with Type";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}