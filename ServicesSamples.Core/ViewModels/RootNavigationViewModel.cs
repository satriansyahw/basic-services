using System.Collections.Generic;
using System.Linq;
using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class RootNavigationViewModel : ListViewModelBase<NavigationItem>
    {
        #region Constructors

        public RootNavigationViewModel()
        {
            List<NavigationItem> items = new List<NavigationItem>();

            items.Add(new NavigationItem("Basic Navigation", "Navigation Services", typeof(BasicNavigationViewModel)));
            items.Add(new NavigationItem("Modal Navigation", "Navigation Services", typeof(ModalNavigationViewModel)));
            items.Add(new NavigationItem("Nested Modal Navigation", "Navigation Services", typeof(NestedNavigationViewModel)));
            items.Add(new NavigationItem("List Navigation", "Navigation Services", typeof(SimpleListViewModel)));

            items.Add(new NavigationItem("Message Presenter", "Presenter Services", typeof(MessagePresenterViewModel)));
            items.Add(new NavigationItem("Toast Presenter", "Presenter Services", typeof(ToastPresenterViewModel)));
            items.Add(new NavigationItem("Action Presenter", "Presenter Services", typeof(ActionPresenterViewModel)));
            items.Add(new NavigationItem("Activity Presenter", "Presenter Services", typeof(ActivityPresenterViewModel)));

            items.Add(new NavigationItem("Telephony & Messaging", "Mobile Services", typeof(TelephonyServicesViewModel)));
            items.Add(new NavigationItem("Camera, Library & Media", "Mobile Services", typeof(CameraServicesViewModel)));
            items.Add(new NavigationItem("Browser & Mail", "Mobile Services", typeof(BrowserServicesViewModel)));

            IApplicationContext context = this.GetService<IApplicationService>().GetContext();
            if (context.Platform.OperatingSystem != OSKind.WinPhone)
                items.Add(new NavigationItem("Contact", "Mobile Services", typeof(ContactServicesViewModel)));

            items.Add(new NavigationItem("Social Sharing", "Mobile Services", typeof(SocialServicesViewModel)));
            items.Add(new NavigationItem("Location & Maps", "Mobile Services", typeof(LocationServicesViewModel)));
            items.Add(new NavigationItem("Notification & Connectivity", "Mobile Services", typeof(NotificationServicesViewModel)));

            items.Add(new NavigationItem("View Service", "Platform Services", typeof(PlatformServicesViewModel)));

            items.Add(new NavigationItem("About This Sample", "About", typeof(AboutViewModel)));

            this.SourceItems = items;
            this.RefreshGroupItems();

            this.Title = "Crosslight App";
        }

        #endregion

        #region Methods

        public override void RefreshGroupItems()
        {
            if (this.Items != null)
                this.GroupItems = this.Items.GroupBy(o => o.Group).Select(o => new GroupItem<NavigationItem>(o)).ToList();
        }

        #endregion
    }
}