using System.IO;
using System.Windows.Media.Imaging;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.Models;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(PhotoViewModel))]
    public partial class PhotoView : PhoneApplicationPage
    {
        #region Constructors

        public PhotoView()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        protected override void OnViewCreated()
        {
            base.OnViewCreated();

            PhotoViewModel viewModel = ViewModel as PhotoViewModel;
            if (viewModel != null)
            {
                Photo photo = viewModel.Item;

                byte[] image = photo.FullImage;
                if (image != null)
                {
                    BitmapSource source = new BitmapImage();
                    using (MemoryStream stream = new MemoryStream(image))
                    {
                        if (stream.Capacity > 0)
                            source.SetSource(stream);
                    }
                    ImageContainer.Source = source;
                }
            }
        }

        #endregion
    }
}