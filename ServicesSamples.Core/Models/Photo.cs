namespace ServicesSamples.Models
{
    public class Photo : ModelBase
    {
        #region Constructors

        public Photo(byte[] fullImage, byte[] thumbnailImage)
        {
            _fullImage = fullImage;
            _thumbnailImage = thumbnailImage;
        }

        #endregion

        #region Fields

        private byte[] _fullImage;
        private byte[] _thumbnailImage;

        #endregion

        #region Properties

        public byte[] FullImage
        {
            get { return _fullImage; }
            set
            {
                if (_fullImage != value)
                {
                    _fullImage = value;
                    OnPropertyChanged("FullImage");
                    OnPropertyChanged("FullSize");
                }
            }
        }

        public int FullSize
        {
            get
            {
                if (_fullImage != null)
                    return _fullImage.Length;

                return 0;
            }
        }

        public byte[] ThumbnailImage
        {
            get { return _thumbnailImage; }
            set
            {
                if (_thumbnailImage != value)
                {
                    _thumbnailImage = value;
                    OnPropertyChanged("ThumbnailImage");
                    OnPropertyChanged("ThumbnailSize");
                }
            }
        }

        public int ThumbnailSize
        {
            get
            {
                if (_thumbnailImage != null)
                    return _thumbnailImage.Length;

                return 0;
            }
        }

        #endregion
    }
}