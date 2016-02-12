using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class ActionPresenterViewModel : ViewModelBase
    {
        #region Constructors

        public ActionPresenterViewModel()
        {
            this.ShowPresenterCommand = new DelegateCommand(ExecuteShowPresenter);
            this.Title = "Action Presenter";
        }

        #endregion

        #region Properties

        public DelegateCommand ShowPresenterCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteShowPresenter(object parameter)
        {
            string showParameter = parameter.ToString();

            if (showParameter == "Standard")
            {
                string[] actions = new string[] {"Take Photo", "Select From Library", "Cancel"};

                this.ActionPresenter.Show("Select Photo", actions, (resultIndex) =>
                {
                    if (resultIndex == -1)
                        this.MessagePresenter.Show("You didn't select any of the choices.");
                    else
                        this.MessagePresenter.Show("You tapped on '" + actions[resultIndex] + "' button");
                });
            }
            else if (showParameter == "Highlight")
            {
                string[] actions = new string[] {"Delete", "Move", "Cancel"};

                this.ActionPresenter.Show("Select an action:", actions, 0, 2, (resultIndex) => { this.MessagePresenter.Show("You tapped on '" + actions[resultIndex] + "' button"); });
            }
        }

        #endregion
    }
}