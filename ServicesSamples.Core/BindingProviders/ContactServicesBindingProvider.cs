using Intersoft.Crosslight;
using ServiceSamples.Converters;

namespace ServicesSamples
{
    public class ContactServicesBindingProvider : BindingProvider
    {
        #region Constructors

        public ContactServicesBindingProvider()
        {
            this.AddBinding("CreateContactButton", BindableProperties.CommandProperty, "CreateContactCommand");
            this.AddBinding("UpdateContactButton", BindableProperties.CommandProperty, "UpdateContactCommand");
            this.AddBinding("DeleteContactButton", BindableProperties.CommandProperty, "DeleteContactCommand");
            this.AddBinding("PickContactButton", BindableProperties.CommandProperty, "PickContactCommand");

            this.AddBinding("TotalContactsLabel", BindableProperties.TextProperty, "TotalContacts");
            this.AddBinding("SelectedContactLabel", BindableProperties.TextProperty, new BindingDescription("SelectedContact")
            {
                Converter = ContactConverter.Instance
            });
        }

        #endregion
    }
}