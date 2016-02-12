using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Models;

namespace ServicesSamples.ViewModels
{
    public class NestedStep1ViewModel : ViewModelBase
    {
        #region Constructors

        public NestedStep1ViewModel()
        {
            this.CancelCommand = new DelegateCommand(ExecuteCancel);
            this.NextCommand = new DelegateCommand(ExecuteNext);
            this.Title = "Step 1";
        }

        #endregion

        #region Fields

        private string _inputText;
        public RegistrationData _registrationData;
        private string _statusText;

        #endregion

        #region Properties

        public DelegateCommand CancelCommand { get; set; }

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

        public DelegateCommand NextCommand { get; set; }

        public RegistrationData RegistrationData
        {
            get { return _registrationData; }
            set
            {
                if (_registrationData != value)
                {
                    _registrationData = value;
                    OnPropertyChanged("RegistrationData");
                }
            }
        }

        public string StatusText
        {
            get { return _statusText; }
            set
            {
                if (_statusText != value)
                {
                    _statusText = value;
                    OnPropertyChanged("StatusText");
                }
            }
        }

        #endregion

        #region Methods

        private void ExecuteCancel(object parameter)
        {
            this.NavigationService.Close(new NavigationResult(NavigationResultAction.Cancel));
        }

        protected virtual void ExecuteNext(object parameter)
        {
            this.NavigationService.Navigate<NestedStep2ViewModel>(new NavigationParameter(this.RegistrationData));
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            this.StatusText = "Registration - Step 1";
            this.InputText = "Crosslight is awesome!";

            this.RegistrationData = parameter.Data as RegistrationData;
        }

        #endregion
    }
}