using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        #region Constructors

        public AboutViewModel()
        {
            this.GreetingText = "Hello World from Crosslight!";
            this.LearnMoreCommand = new DelegateCommand(ExecuteLearnMore);
            this.Title = "About";
        }

        #endregion

        #region Fields

        private string _greetingText;

        #endregion

        #region Properties

        public string GreetingText
        {
            get { return _greetingText; }
            set
            {
                if (_greetingText != value)
                {
                    _greetingText = value;
                    OnPropertyChanged("GreetingText");
                }
            }
        }

        public DelegateCommand LearnMoreCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteLearnMore(object parameter)
        {
            this.MobileService.Browser.Navigate("http://www.intersoftsolutions.com/crosslight");
        }

        #endregion
    }
}