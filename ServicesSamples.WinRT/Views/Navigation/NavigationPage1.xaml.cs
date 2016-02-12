using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(ViewModel1))]
    public sealed partial class NavigationPage1
    {
        #region Constructors

        public NavigationPage1()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}