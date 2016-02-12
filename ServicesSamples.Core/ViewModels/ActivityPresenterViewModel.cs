using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class ActivityPresenterViewModel : ViewModelBase
    {
        #region Constructors

        public ActivityPresenterViewModel()
        {
            this.ShowPresenterCommand = new DelegateCommand(ExecuteShowPresenter);
            this.Title = "Activity Presenter";
        }

        #endregion

        #region Properties

        private bool IsShown { get; set; }
        public DelegateCommand ShowPresenterCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteShowPresenter(object parameter)
        {
            string showParameter = parameter.ToString();

            if (this.IsShown)
                return;

            if (showParameter == "Large")
                this.ActivityPresenter.Show();
            else if (showParameter == "Small")
                this.ActivityPresenter.Show("Updating...", ActivityStyle.SmallIndicatorWithText);
            else if (showParameter == "Translucent")
                this.ActivityPresenter.Show("Loading...", ActivityStyle.TranslucentIndicatorWithText);

            this.IsShown = true;

            // Simulate long-running process
            // Hide the activity presenter after 2.5s
            this.GetService<IViewService>().RunOnBackgroundThread(() =>
            {
                this.ActivityPresenter.Hide();
                this.IsShown = false;
            }, 2500);
        }

        #endregion
    }
}