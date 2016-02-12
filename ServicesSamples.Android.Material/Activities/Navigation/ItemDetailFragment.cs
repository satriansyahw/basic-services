using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ItemDetailBindingProvider))]
	public class ItemDetailFragment : Fragment<ItemDetailViewModel>
    {
        #region Constructors

		public ItemDetailFragment()
        {
        }
			
		public ItemDetailFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}
			
		#endregion

		#region Properties

		protected override int ContentLayoutId 
		{
			get { return Resource.Layout.ItemDetailActivity; }
		}

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Item Detail";
			this.IconId = Resource.Drawable.Icon;
			this.Appearance.Padding = new Thickness(16);
		}

		#endregion
    }
}