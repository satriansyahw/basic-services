using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(NestedStep3BindingProvider))]
	public class NestedStep3Fragment : Fragment<NestedStep3ViewModel>
    {
        #region Constructors

		public NestedStep3Fragment()
        {
        }

		public NestedStep3Fragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}
			
		#endregion

		#region Properties

		protected override int ContentLayoutId 
		{
			get { return Resource.Layout.Step3ContentView; }
		}

		#endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Step 3";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}