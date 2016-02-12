using System;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.Mobile;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class NotificationServicesViewModel : ViewModelBase
    {
        #region Constructors

        public NotificationServicesViewModel()
        {
            this.InvokeServiceCommand = new DelegateCommand(ExecuteInvokeService);
            this.Title = "Notification Services";
        }

        #endregion

        #region Fields

        private bool _isConnectionChangesRegistered = false;

        #endregion

        #region Properties

        public DelegateCommand InvokeServiceCommand { get; set; }

        #endregion

        #region Methods

        protected override void Dispose(bool isDisposing)
        {
            base.Dispose(isDisposing);

            if (isDisposing)
            {
                if (_isConnectionChangesRegistered)
                    this.MobileService.Reachability.StopMonitoringReachabilityChanges(this.OnReachabilityChanged);
            }
        }

        private void ExecuteInvokeService(object parameter)
        {
            string serviceParameter = parameter.ToString();
            bool result = false;

            if (serviceParameter == "GetCurrentConnection")
            {
                result = this.MobileService.Reachability.IsSupported();

                if (result)
                {
                    NetworkConnectionStatus status = this.MobileService.Reachability.GetConnectionStatus();

                    if (status == NetworkConnectionStatus.NoConnection)
                        this.ToastPresenter.Show("Status: No network connection");
                    else if (status == NetworkConnectionStatus.WiFi)
                        this.ToastPresenter.Show("Status: Connected to WiFi");
                    else if (status == NetworkConnectionStatus.WWAN)
                        this.ToastPresenter.Show("Status: Connected to WWAN");
                    else if (status == NetworkConnectionStatus.WiFiAndWWAN)
                        this.ToastPresenter.Show("Status: Connected to both WiFi and WWAN");
                }
            }
            else if (serviceParameter == "GetReachability")
            {
                result = this.MobileService.Reachability.IsSupported();

                if (result)
                {
                    this.ActivityPresenter.Show("Checking...");
                    this.MobileService.Reachability.ShowNetworkActivityIndicator();

                    this.MobileService.Reachability.GetHostReachability("www.intersoftsolutions.com", (reachabilityResult) =>
                    {
                        this.ActivityPresenter.Hide();
                        this.MobileService.Reachability.HideNetworkActivityIndicator();

                        this.ToastPresenter.Show("Reachable: " + reachabilityResult.IsReachable.ToString() + ", Via WWAN: " + reachabilityResult.IsReachableViaWWAN.ToString() + ", Via WiFI: " + reachabilityResult.IsReachableViaWiFi.ToString());
                    });
                }
            }
            else if (serviceParameter == "MonitorConnection")
            {
                result = this.MobileService.Reachability.IsSupported();

                if (result)
                {
                    if (!_isConnectionChangesRegistered)
                    {
                        this.MobileService.Reachability.StartMonitoringReachabilityChanges(this.OnReachabilityChanged);
                        _isConnectionChangesRegistered = true;
                    }

                    this.ToastPresenter.Show("Try to turn on/off the 3G (or the WiFi on your Mac if running on Simulator) to see this feature in action.");
                }
            }
            else if (serviceParameter == "ScheduleNotification")
            {
                result = this.MobileService.Notification.IsSupported();

                if (result)
                {
                    this.ToastPresenter.Show("A local notification is scheduled in the next 5 seconds.");

                    this.MobileService.Notification.ScheduleLocalNotification(new LocalNotification("Intersoft Crosslight", "Congratulations! You've successfully scheduled a local notification in your application", DateTime.Now.AddSeconds(5)));
                }
            }

            if (!result)
                this.ToastPresenter.Show("Location service is not supported in this device/simulator, or not enabled in the Settings.");
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            if (parameter != null)
            {
                if (parameter.Data is LocalNotification)
                {
                    LocalNotification notification = parameter.Data as LocalNotification;

                    this.ToastPresenter.Show("The app is launched from notification center. Received notification: " + notification.Message, notification.Title, null, ToastDisplayDuration.Long, ToastGravity.Top);
                }
            }
        }

        private void OnReachabilityChanged(object sender, ReachabilityEventArgs e)
        {
            if (!e.IsReachable)
                this.ToastPresenter.Show("No Internet connection");
            else if (e.IsReachableViaWiFi)
                this.ToastPresenter.Show("Connected to Internet through WiFi");
            else if (e.IsReachableViaWWAN)
                this.ToastPresenter.Show("Connected to Internet through WWAN");
        }

        #endregion
    }
}