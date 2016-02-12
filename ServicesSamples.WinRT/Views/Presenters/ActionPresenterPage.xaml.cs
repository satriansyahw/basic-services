using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(ActionPresenterViewModel))]
    public sealed partial class ActionPresenterPage
    {
        #region Constructors

        public ActionPresenterPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}