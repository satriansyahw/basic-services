using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class ViewModel3 : ViewModelBase
    {
        #region Constructors

        public ViewModel3()
        {
            this.CancelCommand = new DelegateCommand(ExecuteCancel);
            this.OKCommand = new DelegateCommand(ExecuteOK);
            this.Title = "Modal Navigation Activity";
        }

        #endregion

        #region Fields

        private string _inputText;
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

        public DelegateCommand OKCommand { get; set; }

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

        private void ExecuteOK(object parameter)
        {
            this.NavigationService.Close(new NavigationResult(this.InputText));
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            this.StatusText = "Navigated to ViewModel3";
            this.InputText = "Crosslight is awesome!";
        }

        #endregion
    }
}