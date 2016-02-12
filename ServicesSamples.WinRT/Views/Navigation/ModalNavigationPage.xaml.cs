using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(ModalNavigationViewModel))]
    public sealed partial class ModalNavigationPage
    {
        #region Constructors

        public ModalNavigationPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}