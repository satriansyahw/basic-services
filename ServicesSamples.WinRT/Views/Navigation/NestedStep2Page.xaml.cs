using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(NestedStep2ViewModel))]
    public sealed partial class NestedStep2Page
    {
        #region Constructors

        public NestedStep2Page()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}