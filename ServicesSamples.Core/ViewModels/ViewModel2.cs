using Intersoft.Crosslight;

namespace ServicesSamples.ViewModels
{
    public class ViewModel2 : ViewModel1
    {
        #region Constructors

        public ViewModel2()
        {
            this.Title = "Navigation Activity with Identifier";
        }

        #endregion

        #region Methods

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            // Navigated method is invoked when the ViewModel was successfully instantiated and the associated View was presented.
            // Obtain the passed parameter from the provided NavigatedParameter argument which may carry any type of objects. 
            // This works consistently across all platforms.

            this.StatusText = "Navigated to ViewModel2 along with parameter '" + parameter.Data.ToString() + "'";
        }

        #endregion
    }
}