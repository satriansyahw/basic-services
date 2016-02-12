using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ServicesSamples.ViewModels;

namespace ServicesSamples.iOS.ViewControllers
{
    [ImportBinding(typeof(ListNavigationBindingProvider))]
    public class ListNavigationViewController : UITableViewController<SimpleListViewModel>
    {
        #region Properties

        public override ImageSettings CellImageSettings
        {
            get { return DefaultSettings.ImageSettings; }
        }

        public override TableViewCellStyle CellStyle
        {
            get { return TableViewCellStyle.Subtitle; }
        }

        public override TableViewInteraction InteractionMode
        {
            get { return TableViewInteraction.Navigation; }
        }

        #endregion

        #region Methods

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.ViewModel.ToastPresenter.Show("With list navigation support, master-detail implementation is as easy as inserting one-line of code.");
        }

        #endregion
    }
}