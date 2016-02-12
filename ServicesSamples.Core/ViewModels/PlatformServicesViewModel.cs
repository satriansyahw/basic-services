using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class PlatformServicesViewModel : ViewModelBase
    {
        #region Constructors

        public PlatformServicesViewModel()
        {
            this.Title = "Platform Services";
            this.InvokeServiceCommand = new DelegateCommand(ExecuteInvokeService);
        }

        #endregion

        #region Properties

        public DelegateCommand InvokeServiceCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteInvokeService(object parameter)
        {
            string serviceParameter = parameter.ToString();
            IViewService viewService = this.GetService<IViewService>();

            if (serviceParameter == "RunUI")
                viewService.RunOnUIThreadIfNeeded(() => { this.ToastPresenter.Show("This action runs on the UI thread."); });
            else if (serviceParameter == "RunBackground")
            {
                this.ToastPresenter.Show("Perform long-running task in background...", null, ToastDisplayDuration.Immediate);

                //Simulate long-running background process
                viewService.RunOnBackgroundThread(() =>
                {
                    // Marshal back to UI thread when background operation is completed
                    viewService.RunOnUIThreadIfNeeded(() => this.ToastPresenter.Show("Task performed in background, took 2s."));
                }, 2000);
            }
        }

        #endregion
    }
}