using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(ViewModel2))]
    public sealed partial class NavigationPage2
    {
        #region Constructors

        public NavigationPage2()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}