using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(NestedStep1BindingProvider))]
    public class NestedStep1Fragment : Fragment<NestedStep1ViewModel>
    {
        #region Constructors

		public NestedStep1Fragment()
        {
        }

		public NestedStep1Fragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

		protected override int ContentLayoutId 
		{
			get { return Resource.Layout.Step1ContentView; }
		}

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Step 1";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}