using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using ServicesSamples.ViewModels;

namespace ServicesSamples.WinPhone.Views
{
    [ViewModelType(typeof(NestedStep1ViewModel))]
    public partial class NestedStep1 : PhoneApplicationPage
    {
        #region Constructors

        public NestedStep1()
        {
            InitializeComponent();
        }

        #endregion
    }
}