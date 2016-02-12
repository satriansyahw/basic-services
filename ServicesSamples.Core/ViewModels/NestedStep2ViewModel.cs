using Intersoft.Crosslight;

namespace ServicesSamples.ViewModels
{
    public class NestedStep2ViewModel : NestedStep1ViewModel
    {
        #region Constructors

        public NestedStep2ViewModel()
        {
            this.Title = "Step 2";
        }

        #endregion

        #region Methods

        protected override void ExecuteNext(object parameter)
        {
            this.NavigationService.Navigate<NestedStep3ViewModel>(new NavigationParameter(this.RegistrationData));
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            this.StatusText = "Registration - Step 2";
        }

        #endregion
    }
}