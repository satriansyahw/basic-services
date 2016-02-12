using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(ToastPresenterViewModel))]
    public sealed partial class ToastPresenterPage
    {
        #region Constructors

        public ToastPresenterPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}