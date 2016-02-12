using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class PhotoDetailBindingProvider : BindingProvider
    {
        #region Constructors

        public PhotoDetailBindingProvider()
        {
            this.AddBinding("ThumbnailImageView", BindableProperties.ImageProperty, "Item.ThumbnailImage");
            this.AddBinding("FullSizeImageView", BindableProperties.ImageProperty, "Item.FullImage");

            this.AddBinding("ThumbnailSizeLabel", BindableProperties.TextProperty, "Item.ThumbnailSize");
            this.AddBinding("FullSizeLabel", BindableProperties.TextProperty, "Item.FullSize");

            this.AddBinding("CloseButton", BindableProperties.CommandProperty, "CloseCommand");
        }

        #endregion
    }
}