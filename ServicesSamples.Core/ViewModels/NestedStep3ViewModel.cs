using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;

namespace ServicesSamples.ViewModels
{
    public class NestedStep3ViewModel : NestedStep1ViewModel
    {
        #region Constructors

        public NestedStep3ViewModel()
        {
            this.FinishCommand = new DelegateCommand(ExecuteFinishCommand);
            this.Title = "Step 3";
        }

        #endregion

        #region Properties

        public DelegateCommand FinishCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteFinishCommand(object parameter)
        {
            this.NavigationService.Close(new NavigationResult(this.RegistrationData));
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            this.StatusText = "Registration - Step 3";
        }

        #endregion
    }
}