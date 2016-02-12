using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Models;

namespace ServicesSamples.ViewModels
{
    public class PhotoViewModel : DetailViewModelBase<Photo>
    {
        #region Constructors

        public PhotoViewModel()
        {
            this.CloseCommand = new DelegateCommand(ExecuteClose);
            this.Title = "Photo Detail";
        }

        #endregion

        #region Properties

        public DelegateCommand CloseCommand { get; set; }

        #endregion

        #region Methods

        private void ExecuteClose(object parameter)
        {
            this.NavigationService.Close();
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            this.Item = parameter.Data as Photo;
        }

        #endregion
    }
}