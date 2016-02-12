using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS
{
    [ImportBinding(typeof(MessagePresenterBindingProvider))]
    public partial class MessagePresenterViewController : UIViewController<MessagePresenterViewModel>
    {
        #region Constructors

        public MessagePresenterViewController()
            : base("MessagePresenterView", null)
        {
        }

        #endregion

        #region Properties

        public override bool AutoFitContentSize
        {
            get { return true; }
        }

        #endregion
    }
}