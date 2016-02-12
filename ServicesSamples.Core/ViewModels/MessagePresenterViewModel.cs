using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class MessagePresenterViewModel : ViewModelBase
    {
        #region Constructors

        public MessagePresenterViewModel()
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
                this.MessagePresenter.Show("Data updated successfully.");
            else if (showParameter == "MessageTitle")
                this.MessagePresenter.Show("Your device has no Internet connection.", "Error");
            else if (showParameter == "MessageTitleButtons")
            {
                string[] actions = new string[] {"Yes", "No", "Cancel"};

                this.MessagePresenter.Show("Save message to draft?", "Confirmation", actions, (resultIndex) => { this.MessagePresenter.Show("You clicked '" + actions[resultIndex] + "' button"); });
            }
        }

        #endregion
    }
}