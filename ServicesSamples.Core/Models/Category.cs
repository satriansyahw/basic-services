using Intersoft.Crosslight;

namespace ServicesSamples.Models
{
    [Serializable]
    public partial class Category : ModelBase
    {
        #region Fields

        private int _id;
        private string _image;
        private string _itemCountText;
        private string _name;

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public string Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    OnPropertyChanged("Image");
                }
            }
        }

        public string ItemCountText
        {
            get { return _itemCountText; }
            set
            {
                if (_itemCountText != value)
                {
                    _itemCountText = value;
                    OnPropertyChanged("ItemCountText");
                }
            }
        }

        public byte[] LargeImage { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        #endregion
    }
}