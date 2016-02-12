using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(NestedNavigationViewModel))]
    public sealed partial class NestedNavigationPage
    {
        #region Constructors

        public NestedNavigationPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}