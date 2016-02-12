using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(NestedStep2BindingProvider))]
	public class NestedStep2Fragment : Fragment<NestedStep2ViewModel>
    {
        #region Constructors

        public NestedStep2Fragment()
		{
		}

		public NestedStep2Fragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

		protected override int ContentLayoutId 
		{
			get { return Resource.Layout.Step2ContentView; }
		}

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Step 2";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}