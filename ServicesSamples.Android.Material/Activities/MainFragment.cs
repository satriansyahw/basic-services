using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(NavigationBindingProvider))]
	public class MainFragment : RecyclerViewFragment<RootNavigationViewModel>
    {
		#region Constructors

		public MainFragment ()
		{
		}

		public MainFragment(IntPtr javaReference, JniHandleOwnership transfer)
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
			this.Title = "Crosslight App";
		}

		#endregion
    }
}