using Intersoft.Crosslight;
using ServicesSamples.ViewModels;
using ServicesSamples.WinRT.Common;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    public sealed partial class ListNavigationPage : LayoutAwarePage
    {
        #region Constructors

        public ListNavigationPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}