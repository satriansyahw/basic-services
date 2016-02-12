using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(ActivityPresenterViewModel))]
    public sealed partial class ActivityPresenterPage
    {
        #region Constructors

        public ActivityPresenterPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}