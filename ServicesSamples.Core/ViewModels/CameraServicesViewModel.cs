using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.Mobile;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Models;

namespace ServicesSamples.ViewModels
{
    public class CameraServicesViewModel : ViewModelBase
    {
        #region Constructors

        public CameraServicesViewModel()
        {
            this.InvokeServiceCommand = new DelegateCommand(ExecuteInvokeService);
            this.Title = "Camera Services";
        }

        #endregion

        #region Properties

        public DelegateCommand InvokeServiceCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteInvokeService(object parameter)
        {
            string serviceParameter = parameter.ToString();
            bool result = false;

            if (serviceParameter == "CapturePhoto")
            {
                result = this.MobileService.Camera.IsSupported();

                if (result)
                {
                    this.MobileService.Camera.Capture(new CameraCaptureSettings()
                    {
                        CaptureMode = CameraCaptureMode.Photo,
                        ImageResultMode = ImageResultMode.Both,
                        AllowEditing = true
                    }, (captureResult) =>
                    {
                        if (!captureResult.IsCancelled)
                        {
                            this.NavigationService.Navigate<PhotoViewModel>(new NavigationParameter(NavigationMode.Modal, new Photo(captureResult.ImageData, captureResult.ThumbnailImageData))
                            {
                                ModalPresentationStyle = ModalPresentationStyle.FormSheet
                            });
                        }
                        else
                            this.ToastPresenter.Show("Capture cancelled");
                    });
                }
                else
                    this.ToastPresenter.Show("This function is not supported in this device/simulator.");
            }
            else if (serviceParameter == "CaptureVideo")
            {
                result = this.MobileService.Camera.IsSupported();

                if (result)
                {
                    this.MobileService.Camera.Capture(CameraCaptureMode.Video, (captureResult) =>
                    {
                        if (captureResult != null)
                            this.ToastPresenter.Show("Capture result: " + (captureResult.IsCancelled ? "Cancelled" : captureResult.MediaUrl + " was saved"));
                    });
                }
                else
                    this.ToastPresenter.Show("This function is not supported in this device/simulator.");
            }
            else if (serviceParameter == "ChooseLibrary")
            {
                result = this.MobileService.MediaLibrary.IsSupported();

                if (result)
                {
                    this.MobileService.MediaLibrary.ShowPicker(new MediaLibrarySettings()
                    {
                        MediaType = CameraMediaType.Photo,
                        Source = MediaLibraryType.PhotoLibrary,
                        ImageResultMode = ImageResultMode.Both
                    }, (pickerResult) =>
                    {
                        if (!pickerResult.IsCancelled)
                        {
                            this.NavigationService.Navigate<PhotoViewModel>(new NavigationParameter(NavigationMode.Modal, new Photo(pickerResult.ImageData, pickerResult.ThumbnailImageData))
                            {
                                ModalPresentationStyle = ModalPresentationStyle.FormSheet
                            });
                        }
                        else
                            this.ToastPresenter.Show("Picker cancelled");
                    });
                }
                else
                    this.ToastPresenter.Show("This function is not supported in this device/simulator.");
            }
            else if (serviceParameter == "PlaySound")
            {
                result = this.MobileService.Media.IsSupported();

                if (result)
                    this.MobileService.Media.PlaySound("welcome.mp3");
                else
                    this.ToastPresenter.Show("This function is not supported in this device/simulator.");
            }
            else if (serviceParameter == "OpenYoutube")
            {
                result = this.MobileService.Media.IsSupported();

                if (result)
                    this.MobileService.Media.OpenYouTube("KhyWgC2z24s");
                else
                    this.ToastPresenter.Show("This function is not supported in this device/simulator.");
            }

            if (!result)
                this.ToastPresenter.Show("This function is not supported in this device/simulator.");
        }

        #endregion
    }
}