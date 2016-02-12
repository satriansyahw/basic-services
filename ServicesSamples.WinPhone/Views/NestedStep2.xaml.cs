using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(NestedStep2ViewModel))]
    public partial class NestedStep2 : PhoneApplicationPage
    {
        #region Constructors

        public NestedStep2()
        {
            InitializeComponent();
        }

        #endregion
    }
}