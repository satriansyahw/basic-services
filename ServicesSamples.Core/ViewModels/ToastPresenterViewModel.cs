using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class ToastPresenterViewModel : ViewModelBase
    {
        #region Constructors

        public ToastPresenterViewModel()
        {
            this.ShowPresenterCommand = new DelegateCommand(ExecuteShowPresenter);
            this.Title = "Platform Services";
        }

        #endregion

        #region Properties

        public DelegateCommand ShowPresenterCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteShowPresenter(object parameter)
        {
            string showParameter = parameter.ToString();

            if (showParameter == "Message")
                this.ToastPresenter.Show("Changes saved.");
            else if (showParameter == "MessageTitle")
                this.ToastPresenter.Show("Synchronizing to cloud service...", "Status");
            else if (showParameter == "MessageTitleImage")
                this.ToastPresenter.Show("You're now connected to Internet", "Info", "info.png");
            else if (showParameter == "UseOverlay")
            {
                this.ToastPresenter.Show("Processing...", null, null, new ToastSettings()
                {
                    OverlayEnabled = true,
                    Gravity = ToastGravity.Center
                });
            }
            else if (showParameter == "Top")
                this.ToastPresenter.Show("Data synchronized successfully", "Info", "info.png", ToastDisplayDuration.Immediate, ToastGravity.Top);
            else if (showParameter == "Center")
                this.ToastPresenter.Show("Data synchronized successfully", "Info", "info.png", ToastDisplayDuration.Immediate, ToastGravity.Center);
            else if (showParameter == "UseOwner")
            {
                this.ToastPresenter.Show("This toast is placed in the current view context", "Info", "info.png", new ToastSettings()
                {
                    Owner = this,
                    Gravity = ToastGravity.Center
                });
            }
            else if (showParameter == "ShortDuration")
                this.ToastPresenter.Show("Data synchronized successfully", "Info", "info.png", ToastDisplayDuration.Short, ToastGravity.Center);
        }

        #endregion
    }
}