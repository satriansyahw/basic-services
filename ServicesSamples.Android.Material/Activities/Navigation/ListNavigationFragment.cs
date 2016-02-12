using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ListNavigationBindingProvider))]
	public class ListNavigationFragment : RecyclerViewFragment<SimpleListViewModel>
    {
		#region Constructors

		public ListNavigationFragment ()
		{
		}
			
		public ListNavigationFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.IconId = Resource.Drawable.Icon;
			this.InteractionMode = ListViewInteraction.Navigation;
			this.Title = "List Navigation";
		}

		#endregion
    }
}