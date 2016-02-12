using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ServicesSamples.WinPhone.Converters
{
    public sealed class ByteToImageConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            byte[] img = value as byte[];

            if (img == null)
                return null;

            using (MemoryStream stream = new MemoryStream(img))
            {
                BitmapSource source = new BitmapImage();
                source.SetSource(stream);

                return source;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}