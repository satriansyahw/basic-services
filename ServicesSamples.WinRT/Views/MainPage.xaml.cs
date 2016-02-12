using System.Linq;
using Windows.UI.ViewManagement;
using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT
{
    /// <summary>
    ///     The main navigation page with the list view in the left panel and the detail frame in the right panel.
    /// </summary>
    [ViewModelType(typeof(RootNavigationViewModel))]
    public sealed partial class MainPage
    {
        #region Constructors

        public MainPage()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Properties

        public new RootNavigationViewModel ViewModel
        {
            get { return base.ViewModel as RootNavigationViewModel; }
        }

        #endregion

        #region Methods

        protected override void InitializeViewModel()
        {
            base.InitializeViewModel();

            // set initial selection for split page
            this.ViewModel.SelectedItem = this.ViewModel.Items.ElementAtOrDefault(0);
        }

        public override void InvalidateLayoutVisualState()
        {
            base.InvalidateLayoutVisualState();

            if (ApplicationView.Value != ApplicationViewState.Snapped)
            {
                if (this.ViewModel.SelectedItem == null)
                    this.itemDetail.Content = null;
            }
        }

        #endregion
    }
}