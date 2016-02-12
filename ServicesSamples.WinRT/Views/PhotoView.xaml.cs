using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Intersoft.Crosslight;
using ServicesSamples.Models;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(PhotoViewModel))]
    public partial class PhotoView
    {
        #region Constructors

        public PhotoView()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        protected async override void OnViewCreated()
        {
            base.OnViewCreated();

            PhotoViewModel viewModel = ViewModel as PhotoViewModel;
            if (viewModel != null)
            {
                Photo photo = viewModel.Item;

                byte[] image = photo.FullImage;
                if (image != null)
                {
                    using (var stream = new InMemoryRandomAccessStream())
                    {
                        await stream.WriteAsync(image.AsBuffer());
                        var images = new BitmapImage();
                        stream.Seek(0);
                        images.SetSource(stream);
                        ImageContainer.Source = images;
                    }
                }
            }
        }

        #endregion
    }
}