using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.Mobile;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class LocationServicesViewModel : ViewModelBase
    {
        #region Constructors

        public LocationServicesViewModel()
        {
            this.InvokeServiceCommand = new DelegateCommand(ExecuteInvokeService);
            this.Title = "Location Services";
        }

        #endregion

        #region Fields

        private bool _isProcessing = false;

        #endregion

        #region Properties

        public DelegateCommand InvokeServiceCommand { get; set; }

        #endregion

        #region Methods

        protected override void Dispose(bool isDisposing)
        {
            base.Dispose(isDisposing);

            if (_isProcessing)
                this.ActivityPresenter.Hide();
        }

        private void ExecuteInvokeService(object parameter)
        {
            string serviceParameter = parameter.ToString();
            bool result = this.MobileService.Location.IsSupported();

            if (_isProcessing)
                return;

            if (serviceParameter == "GetMyLocation")
            {
                if (result)
                {
                    _isProcessing = true;
                    this.ActivityPresenter.Show("Acquiring location...");

                    this.MobileService.Location.GetCurrentLocation(LocationAccuracy.Best, (locationResult) =>
                    {
                        _isProcessing = false;
                        this.ActivityPresenter.Hide();

                        if (locationResult.Error == null)
                            this.MessagePresenter.Show("My location is at " + locationResult.Location.Coordinate.Latitude + "," + locationResult.Location.Coordinate.Longitude);
                        else
                            this.MessagePresenter.Show("Unable to acquire location due to error '" + locationResult.Error.ToString() + "'");
                    });
                }
            }
            else if (serviceParameter == "ShowMyLocation")
            {
                if (result)
                    this.MobileService.Map.NavigateToCurrentLocation();
            }
            else if (serviceParameter == "ShowLocationAddress")
            {
                if (result)
                {
                    _isProcessing = true;
                    this.ActivityPresenter.Show("Looking for Intersoft Solutions...", ActivityStyle.SmallIndicatorWithText, true);

                    this.MobileService.Location.GetPlacemark(new PlacemarkAddress("Bulevar Artha Gading A6B 28", "14240", "Jakarta", "Indonesia"), (placemarkResult) =>
                    {
                        _isProcessing = false;
                        this.ActivityPresenter.Hide();

                        if (placemarkResult.Error == null)
                        {
                            placemarkResult.Placemark.Name = "Intersoft Solutions";
                            this.MobileService.Map.Navigate(placemarkResult.Placemark, 14);
                        }
                        else
                            this.MessagePresenter.Show("Unable to find the placemark due to an error.");
                    });
                }
            }
            else if (serviceParameter == "ShowDirections")
            {
                if (result)
                {
                    Placemark from = new Placemark(new Location(new LocationCoordinate(37.46418, -86.45172)));
                    Placemark to = new Placemark(new Location(new LocationCoordinate(38.76957, -89.25629)));

                    from.Name = "Source Location";
                    to.Name = "Carlyle Lake, Clinton and Bond Cos.";

                    this.MobileService.Map.ShowDirections(from, to, MapDirectionMode.Driving);
                }
            }
            else if (serviceParameter == "CheckLocation")
            {
                if (result)
                {
                    _isProcessing = true;
                    this.ActivityPresenter.Show("Acquiring location...");

                    this.MobileService.Location.GetCurrentLocation(LocationAccuracy.Best, (locationResult) =>
                    {
                        _isProcessing = false;
                        this.ActivityPresenter.Hide();

                        if (locationResult.Error == null)
                        {
                            // To test this feature, set the Location to Custom: -6.141, 106.91
                            bool isNear = this.MobileService.Location.IsLocationInRange(new LocationCoordinate(-6.14, 106.9), locationResult.Location.Coordinate, 200);
                            this.MessagePresenter.Show("Result: " + isNear.ToString());
                        }
                        else
                            this.MessagePresenter.Show("Unable to acquire location due to error '" + locationResult.Error.ToString() + "'");
                    });
                }
            }

            if (!result)
                this.ToastPresenter.Show("Location service is not supported in this device/simulator, or not enabled in the Settings.");
        }

        #endregion
    }
}