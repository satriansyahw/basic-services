using Intersoft.Crosslight;

namespace ServicesSamples
{
    public class ModalNavigationBindingProvider : BindingProvider
    {
        #region Constructors

        public ModalNavigationBindingProvider()
        {
            IApplicationContext context = this.GetService<IApplicationService>().GetContext();

            this.AddBinding("NavigateModalButton", BindableProperties.CommandProperty, "NavigateModalCommand");
            this.AddBinding("NavigateModalButton", BindableProperties.CommandParameterProperty, "Default", true);

            this.AddBinding("SlideButton", BindableProperties.CommandProperty, "NavigateModalCommand");
            this.AddBinding("SlideButton", BindableProperties.CommandParameterProperty, "Slide", true);

            this.AddBinding("FlipButton", BindableProperties.CommandProperty, "NavigateModalCommand");
            this.AddBinding("FlipButton", BindableProperties.CommandParameterProperty, "Flip", true);

            this.AddBinding("FadeButton", BindableProperties.CommandProperty, "NavigateModalCommand");
            this.AddBinding("FadeButton", BindableProperties.CommandParameterProperty, "Fade", true);

            if (context.Platform.OperatingSystem != OSKind.Android)
            {
                this.AddBinding("CurlButton", BindableProperties.CommandProperty, "NavigateModalCommand");
                this.AddBinding("CurlButton", BindableProperties.CommandParameterProperty, "Curl", true);
            }
        }

        #endregion
    }
}