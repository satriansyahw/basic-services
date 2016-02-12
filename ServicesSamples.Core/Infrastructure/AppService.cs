using Intersoft.Crosslight;
using ServicesSamples.ModelServices;
using ServicesSamples.ViewModels;

namespace ServicesSamples.Infrastructure
{
    public sealed class ServicesSamplesAppService : ApplicationServiceBase
    {
        #region Constructors

        public ServicesSamplesAppService(IApplicationContext context)
            : base(context)
        {
        }

        #endregion

        #region Methods

        protected override void OnNotificationReceived(Notification notification)
        {
            base.OnNotificationReceived(notification);

            if (this.State == ApplicationState.Active)
            {
                // If application is running in foreground (active),
                // Show an in-app toast directly to user
                this.GetService<IPresenterService>().GetPresenter<IToastPresenter>().Show("Received local notification:" + notification.Message, notification.Title);
            }
            else
            {
                // If application is in background or not running,
                // Redirect user to the desired ViewModel along with the notification object
                this.Navigate(new NavigationTarget(typeof(NotificationServicesViewModel), new NavigationParameter(notification)));
            }
        }

        protected override void OnStart(StartParameter parameter)
        {
            base.OnStart(parameter);

            // Register required core app-level services via IoC
            // Container.Current.Register<IPaymentProcessor, PaypalPaymentProcessor>();

            Container.Current.Register<IItemRepository, ItemRepository>();
            Container.Current.Register<ICategoryRepository, CategoryRepository>();

            // Set the root ViewModel to be displayed at startup
            this.SetRootViewModel<RootNavigationViewModel>();
        }

        #endregion
    }
}