using Android.App;
using Android.Content.PM;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;
using System;
using Android.Runtime;

namespace ServicesSamples.Android
{
    //[Activity(Label = "Message Presenter", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Icon = "@drawable/icon")]
    [ImportBinding(typeof(MessagePresenterBindingProvider))]
	public class MessagePresenterFragment : Fragment<MessagePresenterViewModel>
    {
		#region Constructors

		public MessagePresenterFragment ()
		{
		}

		public MessagePresenterFragment(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		#endregion

		#region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.MessagePresenterView; }
        }

        #endregion

		#region Methods

		protected override void Initialize ()
		{
			base.Initialize ();

			this.Title = "Platform Services";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion
    }
}