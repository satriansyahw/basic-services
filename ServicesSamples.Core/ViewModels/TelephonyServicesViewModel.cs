using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class TelephonyServicesViewModel : ViewModelBase
    {
        #region Constructors

        public TelephonyServicesViewModel()
        {
            this.PhoneNumber = "+18885487685";
            this.InvokeServiceCommand = new DelegateCommand(ExecuteInvokeService);
            this.Title = "Telephony Services";
        }

        #endregion

        #region Fields

        private string _phoneNumber;

        #endregion

        #region Properties

        public DelegateCommand InvokeServiceCommand { get; set; }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }

        #endregion

        #region Methods

        private void ExecuteInvokeService(object parameter)
        {
            string showParameter = parameter.ToString();
            bool result = false;

            if (string.IsNullOrEmpty(this.PhoneNumber))
            {
                this.MessagePresenter.Show("Please enter a phone number.");
                return;
            }

            if (showParameter == "Call")
            {
                result = this.MobileService.Telephony.IsSupported();

                if (result)
                    this.MobileService.Telephony.Call(this.PhoneNumber);
            }
            else if (showParameter == "Message")
            {
                result = this.MobileService.Messaging.IsSupported();

                if (result)
                    this.MobileService.Messaging.SendMessage(this.PhoneNumber);
            }

            if (!result)
                this.ToastPresenter.Show("This function is not supported in this device/simulator.");
        }

        #endregion
    }
}