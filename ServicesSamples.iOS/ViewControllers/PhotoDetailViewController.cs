using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(PhotoDetailBindingProvider))]
    public partial class PhotoDetailViewController : UIViewController<PhotoViewModel>
    {
        #region Constructors

        public PhotoDetailViewController()
            : base("PhotoDetailViewController", null)
        {
        }

        #endregion
    }
}