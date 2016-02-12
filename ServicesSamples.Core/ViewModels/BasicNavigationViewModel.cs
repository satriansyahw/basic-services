using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class BasicNavigationViewModel : ViewModelBase
    {
        #region Constructors

        public BasicNavigationViewModel()
        {
            this.NavigateTypeCommand = new DelegateCommand(ExecuteNavigateType);
            this.NavigateIdentifierCommand = new DelegateCommand(ExecuteNavigateIdentifier);
            this.NavigateParameterCommand = new DelegateCommand(ExecuteNavigateParameter);

            this.InputText = "Hello from Crosslight!";
            this.Title = "Basic Navigation";
        }

        #endregion

        #region Fields

        private string _inputText;

        #endregion

        #region Properties

        public string InputText
        {
            get { return _inputText; }
            set
            {
                if (_inputText != value)
                {
                    _inputText = value;
                    OnPropertyChanged("InputText");
                }
            }
        }

        public DelegateCommand NavigateIdentifierCommand { get; set; }
        public DelegateCommand NavigateParameterCommand { get; set; }
        public DelegateCommand NavigateTypeCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteNavigateIdentifier(object parameter)
        {
            this.NavigationService.Navigate<ViewModel1>("ViewModel1Derivative");
        }

        private void ExecuteNavigateParameter(object parameter)
        {
            // You can pass any objects as parameter during navigation
            this.NavigationService.Navigate<ViewModel2>(new NavigationParameter(parameter));
        }

        private void ExecuteNavigateType(object parameter)
        {
            this.NavigationService.Navigate<ViewModel1>();
        }

        #endregion
    }
}