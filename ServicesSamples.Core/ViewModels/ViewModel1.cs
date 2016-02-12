using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class ViewModel1 : ViewModelBase
    {
        #region Constructors

        public ViewModel1()
        {
            this.CloseCommand = new DelegateCommand(ExecuteClose);
            this.Title = "Navigation Activity with Type";
        }

        #endregion

        #region Fields

        private string _statusText;

        #endregion

        #region Properties

        public DelegateCommand CloseCommand { get; set; }

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

        private void ExecuteClose(object parameter)
        {
            this.NavigationService.Close();
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            this.StatusText = "Navigated to ViewModel1";
        }

        #endregion
    }
}