using System;
using System.Globalization;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Mobile;

namespace ServiceSamples.Converters
{
    public class ContactConverter : IValueConverter
    {
        #region Fields

        public static ContactConverter Instance = new ContactConverter();

        #endregion

        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Contact contact = value as Contact;
            if (contact != null)
            {
                if (!string.IsNullOrEmpty(contact.DisplayName))
                    return contact.DisplayName;
                else if (!string.IsNullOrEmpty(contact.FirstName) || !string.IsNullOrEmpty(contact.LastName))
                    return string.Join(" ", contact.FirstName, contact.LastName);
                else if (contact.Emails.Count > 0 && !string.IsNullOrEmpty(contact.Emails[0].Address))
                    return contact.Emails[0].Address;
                else
                    return "(no name)";
            }

            return "-";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}