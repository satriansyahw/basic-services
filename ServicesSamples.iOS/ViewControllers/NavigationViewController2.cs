using Intersoft.Crosslight;

namespace ServicesSamples.iOS.ViewControllers
{
    [ImportBinding(typeof(ViewModel1BindingProvider))]
    [RegisterNavigation("ViewModel1Derivative")]
    public partial class NavigationViewController2 : NavigationViewController1
    {
        #region Methods

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.ViewModel.ToastPresenter.Show("Navigated to ViewModel1 but presented with different View.");
        }

        #endregion
    }
}