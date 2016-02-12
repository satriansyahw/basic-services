using System;
using Windows.UI.Xaml.Data;

namespace ServicesSamples.WinRT.Converters
{
    public class DecimalToDoubleConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return System.Convert.ChangeType(value, typeof(double));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return System.Convert.ChangeType(value, typeof(decimal));
        }

        #endregion
    }
}