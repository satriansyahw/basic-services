using System.Linq;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.Mobile;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Infrastructure;
using ServicesSamples.Models;
using ServicesSamples.ModelServices;

namespace ServicesSamples.ViewModels
{
    public class BrowserServicesViewModel : ViewModelBase
    {
        #region Constructors

        public BrowserServicesViewModel()
        {
            this.InvokeServiceCommand = new DelegateCommand(ExecuteInvokeService);
            this.Title = "Browser Services";
        }

        #endregion

        #region Properties

        public DelegateCommand InvokeServiceCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteInvokeService(object parameter)
        {
            string serviceParameter = parameter.ToString();
            bool result = false;

            if (serviceParameter == "OpenBrowser")
            {
                result = this.MobileService.Browser.IsSupported();

                if (result)
                    this.MobileService.Browser.Navigate("http://www.intersoftsolutions.com/crosslight");
            }
            else if (serviceParameter == "ComposeMail")
            {
                result = this.MobileService.Mail.IsSupported();

                if (result)
                {
                    // This example shows basic compose mail usage, without needing to know the result.
                    this.MobileService.Mail.ComposeMail("sales@intersoftsolutions.com", "Product inquiry", "I'd like to inquire more information about your product. Please contact me back.", null);
                }
            }
            else if (serviceParameter == "ComposeMailAdvanced")
            {
                result = this.MobileService.Mail.IsSupported();

                if (result)
                {
                    // This example shows a more advanced mail compose that includes Cc recipient, attachments, 
                    // and also capturing the compose mail result.

                    MailMessage message = new MailMessage("sales@sampleshop.com", "Product inquiry", "I'm interested in the product similar to the attachment.");

                    Item item = Container.Current.Resolve<IItemRepository>().GetAll().First();
                    MailAttachment attachment = new MailAttachment("Product.png", "image/png", item.ThumbnailImage);

                    message.AddCcRecipient("inquiry@samlepshop.com");
                    message.AddAttachment(attachment);

                    this.MobileService.Mail.ComposeMail(message, (composeResult) => this.ToastPresenter.Show("The mail compose result is: " + composeResult.Status.ToString()));
                }
            }

            if (!result)
                this.ToastPresenter.Show("This function is not supported in this device/simulator.");
        }

        #endregion
    }
}