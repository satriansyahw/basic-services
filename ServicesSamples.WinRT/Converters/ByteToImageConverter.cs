﻿using System;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;
using Intersoft.Crosslight.WinRT;

namespace ServicesSamples.WinRT.Converters
{
    public sealed class ByteToImageConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            byte[] img = value as byte[];

            if (img == null)
                return null;

            InMemoryRandomAccessStream ras = new InMemoryRandomAccessStream();
            DataWriter dw = new DataWriter(ras.GetOutputStreamAt(0));
            dw.WriteBytes(img);
            dw.StoreAsync().Await();

            BitmapImage image = new BitmapImage();
            image.SetSource(ras);

            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}