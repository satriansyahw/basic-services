using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class ModalNavigationViewModel : ViewModelBase
    {
        #region Constructors

        public ModalNavigationViewModel()
        {
            this.NavigateModalCommand = new DelegateCommand(ExecuteNavigateModal);
            this.Title = "Modal Navigation";
        }

        #endregion

        #region Properties

        public DelegateCommand NavigateModalCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteNavigateModal(object parameter)
        {
            string mode = parameter.ToString();
            NavigationParameter navigationParameter = new NavigationParameter()
            {
                NavigationMode = NavigationMode.Modal
            };

            switch (mode)
            {
                case "Default":
                case "Slide":
                    navigationParameter.ModalTransitionStyle = ModalTransitionStyle.Default;
                    break;

                case "Fade":
                    navigationParameter.ModalTransitionStyle = ModalTransitionStyle.Fade;
                    break;

                case "Flip":
                    navigationParameter.ModalTransitionStyle = ModalTransitionStyle.Flip;
                    break;

                case "Curl":
                    navigationParameter.ModalTransitionStyle = ModalTransitionStyle.Curl;
                    break;
            }

            this.NavigationService.Navigate(new NavigationTarget(typeof(ViewModel3), navigationParameter), (result) =>
            {
                if (result.Action == NavigationResultAction.Cancel)
                    this.MessagePresenter.Show("You cancelled the data input");
                else
                    this.MessagePresenter.Show("You entered: " + result.Data.ToString());
            });
        }

        #endregion
    }
}