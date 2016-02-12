using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(NestedStep3ViewModel))]
    public partial class NestedStep3 : PhoneApplicationPage
    {
        #region Constructors

        public NestedStep3()
        {
            InitializeComponent();
        }

        #endregion
    }
}