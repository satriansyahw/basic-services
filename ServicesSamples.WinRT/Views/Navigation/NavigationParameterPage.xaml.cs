using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(ViewModel1))]
    [RegisterNavigation("ViewModel1Derivative")]
    public sealed partial class NavigationParameterPage
    {
        #region Constructors

        public NavigationParameterPage()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();
            (this.ViewModel as ViewModel1).ToastPresenter.Show("Navigated to ViewModel1 but presented with different view.");
        }

        #endregion
    }
}