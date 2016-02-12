using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(MessagePresenterViewModel))]
    public sealed partial class MessagePresenterPage
    {
        #region Constructors

        public MessagePresenterPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}