using System.Linq;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.Mobile;
using Intersoft.Crosslight.ViewModels;

namespace ServicesSamples.ViewModels
{
    public class ContactServicesViewModel : ViewModelBase
    {
        #region Constructors

        public ContactServicesViewModel()
        {
            this.CreateContactCommand = new DelegateCommand(ExecuteCreateContact);
            this.UpdateContactCommand = new DelegateCommand(ExecuteUpdateContact, CanExecuteUpdateContact);
            this.DeleteContactCommand = new DelegateCommand(ExecuteDeleteContact, CanExecuteDeleteContact);
            this.PickContactCommand = new DelegateCommand(ExecutePickContact);

            this.Title = "Contact Services";
            this.InvalidateTotalContacts();
        }

        #endregion

        #region Fields

        private Contact _selectedContact;
        private int _totalContacts;

        #endregion

        #region Properties

        public DelegateCommand CreateContactCommand { get; set; }
        public DelegateCommand DeleteContactCommand { get; set; }
        public DelegateCommand PickContactCommand { get; set; }

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                if (_selectedContact != value)
                {
                    _selectedContact = value;
                    OnPropertyChanged("SelectedContact");

                    this.UpdateContactCommand.RaiseCanExecuteChanged();
                    this.DeleteContactCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public int TotalContacts
        {
            get { return _totalContacts; }
            set
            {
                if (_totalContacts != value)
                {
                    _totalContacts = value;
                    OnPropertyChanged("TotalContacts");
                }
            }
        }

        public DelegateCommand UpdateContactCommand { get; set; }

        #endregion

        #region Methods

        public bool CanExecuteDeleteContact(object parameter)
        {
            return this.SelectedContact != null;
        }

        public bool CanExecuteUpdateContact(object parameter)
        {
            return this.SelectedContact != null;
        }

        public void ExecuteCreateContact(object parameter)
        {
            this.NavigationService.Navigate<ContactEditorViewModel>(new NavigationParameter(NavigationMode.Modal)
            {
                EnsureNavigationContext = true
            }, (result) =>
            {
                if (result.Action == NavigationResultAction.Done)
                {
                    this.SelectedContact = result.Data as Contact;
                    this.InvalidateTotalContacts();
                }
            });
        }

        public void ExecuteDeleteContact(object parameter)
        {
            if (this.SelectedContact != null)
            {
                this.MobileService.Contact.DeleteContact(this.SelectedContact);
                this.SelectedContact = null;
                this.InvalidateTotalContacts();
                this.ToastPresenter.Show("The selected contact has been deleted", ToastDisplayDuration.Immediate);
            }
        }

        public void ExecutePickContact(object parameter)
        {
            this.MobileService.Contact.PickContact((result) =>
            {
                if (!result.IsCancelled)
                {
                    this.SelectedContact = result.Contact;
                    this.ToastPresenter.Show("1 contact is selected", ToastDisplayDuration.Immediate);
                }
                else
                    this.ToastPresenter.Show("Action is cancelled", ToastDisplayDuration.Immediate);
            });
        }

        public void ExecuteUpdateContact(object parameter)
        {
            if (this.SelectedContact != null)
            {
                this.NavigationService.Navigate<ContactEditorViewModel>(new NavigationParameter(NavigationMode.Modal, this.SelectedContact)
                {
                    EnsureNavigationContext = true
                }, (result) =>
                {
                    if (result.Action == NavigationResultAction.Done)
                    {
                    }
                });
            }
        }

        public void InvalidateTotalContacts()
        {
            var contacts = this.MobileService.Contact.LoadContacts();

            if (contacts != null)
                this.TotalContacts = contacts.Count();
            else
                this.TotalContacts = 0;
        }

        #endregion
    }
}