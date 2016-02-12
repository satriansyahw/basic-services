using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Models;

namespace ServicesSamples.ViewModels
{
    public class NestedNavigationViewModel : ViewModelBase
    {
        #region Constructors

        public NestedNavigationViewModel()
        {
            this.NavigateModalCommand = new DelegateCommand(ExecuteNavigateModal);
            this.Title = "Nested Modal Navigation";
        }

        #endregion

        #region Properties

        public DelegateCommand NavigateModalCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteNavigateModal(object parameter)
        {
            NavigationParameter navigationParameter = new NavigationParameter(new RegistrationData())
            {
                NavigationMode = NavigationMode.Modal,
                EnsureNavigationContext = true
            };

            this.NavigationService.Navigate(new NavigationTarget(typeof(NestedStep1ViewModel), navigationParameter), (result) =>
            {
                if (result.Action == NavigationResultAction.Cancel)
                    this.MessagePresenter.Show("You cancelled the data input");
                else
                    this.ShowRegistrationData(result.Data as RegistrationData);
            });
        }

        private void ShowRegistrationData(RegistrationData data)
        {
            string message = @"You're registered with:
Email: " + data.Email + @"
Name: " + data.Name + @"
Contact: " + data.Contact;

            this.MessagePresenter.Show(message);
        }

        #endregion
    }
}