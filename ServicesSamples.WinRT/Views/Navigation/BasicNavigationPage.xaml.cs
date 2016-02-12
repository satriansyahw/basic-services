using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(BasicNavigationViewModel))]
    public sealed partial class BasicNavigationPage
    {
        #region Constructors

        public BasicNavigationPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}