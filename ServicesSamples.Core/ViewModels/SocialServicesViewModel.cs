using System.Linq;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Infrastructure;
using ServicesSamples.Models;
using ServicesSamples.ModelServices;

namespace ServicesSamples.ViewModels
{
    public class SocialServicesViewModel : ViewModelBase
    {
        #region Constructors

        public SocialServicesViewModel()
        {
            this.InvokeServiceCommand = new DelegateCommand(ExecuteInvokeService);
            this.Title = "Social Services";
        }

        #endregion

        #region Properties

        public DelegateCommand InvokeServiceCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteInvokeService(object parameter)
        {
            string serviceParameter = parameter.ToString();
            bool result = this.MobileService.Social.IsSupported();
            Item item = Container.Current.Resolve<IItemRepository>().GetAll().First();

            if (serviceParameter == "Share")
            {
                if (result)
                    this.MobileService.Social.ShowShareOptions("Hello from Intersoft Crosslight", new object[] {item.ThumbnailImage}, ShareActivityType.All);
            }
            else if (serviceParameter == "ShareSocial")
            {
                if (result)
                    this.MobileService.Social.ShowShareOptions("Hello from Intersoft Crosslight", new object[] {item.ThumbnailImage}, ShareActivityType.PostToTwitter | ShareActivityType.PostToFacebook);
            }
            else if (serviceParameter == "PostFacebook")
            {
                if (result)
                    this.MobileService.Social.PostToFacebook("My brand-new Canon!", item.ThumbnailImage, null);
            }
            else if (serviceParameter == "PostTwitter")
            {
                if (result)
                    this.MobileService.Social.PostToTwitter("My brand-new Canon!", item.ThumbnailImage, null);
            }

            if (!result)
                this.ToastPresenter.Show("This function is not supported in this device/simulator.");
        }

        #endregion
    }
}