using Intersoft.Crosslight;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinRT.Views
{
    [ViewModelType(typeof(NestedStep1ViewModel))]
    public sealed partial class NestedStep1Page
    {
        #region Constructors

        public NestedStep1Page()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}