using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using ServicesSamples.ViewModels;
using Intersoft.Crosslight.Android.v7.ComponentModels;

namespace ServicesSamples.Android
{
    [ImportBinding(typeof(ServicesBindingProvider))]
    public class TelephonyServicesFragment : Fragment<TelephonyServicesViewModel>
    {
		#region Constructors

		public TelephonyServicesFragment ()
		{
			this.Title = "Telephony Services";
			this.IconId = Resource.Drawable.Icon;
		}

		#endregion

		#region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.TelephonyServicesView; }
        }

        #endregion
    }
}