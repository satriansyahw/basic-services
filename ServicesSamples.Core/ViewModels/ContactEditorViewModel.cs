using System;
using System.Windows.Input;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Forms;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.Mobile;
using Intersoft.Crosslight.ViewModels;
using ServicesSamples.Models;

namespace ServicesSamples.ViewModels
{
    public class ContactEditorViewModel : EditorViewModelBase<Contact>
    {
        #region Constructors

        public ContactEditorViewModel()
        {
            this.Title = "Edit Contact";
            this.FinishImagePickerCommand = new DelegateCommand(ExecuteFinishImagePickerCommand);
        }

        #endregion

        #region Fields

        private Email _email;
        private Phone _phone;

        #endregion

        #region Properties

        public Email Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public ICommand FinishImagePickerCommand { get; set; }

        public override Type FormMetadataType
        {
            get { return typeof(ContactFormMetadata); }
        }

        public Phone Phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }

        #endregion

        #region Methods

        protected override void ExecuteCancel(object parameter)
        {
            base.ExecuteCancel(parameter);

            // In real world scenario, roll back all changes to the original state.
        }

        private void ExecuteFinishImagePickerCommand(object parameter)
        {
            ImagePickerResultParameter resultParameter = parameter as ImagePickerResultParameter;

            if (resultParameter != null && resultParameter.Result != null)
                this.Item.Photo = resultParameter.Result.ImageData;
        }

        protected override void ExecuteSave(object parameter)
        {
            // This sample doesn't implement physical data save as it uses XML as datasource
            // In real world apps, save the data to either local storage, Azure or web service.

            // Validate the item associated to this ViewModel
            this.Validate();

            // Perform save if there are no validation errors
            if (!this.HasErrors)
            {
                if (this.IsDirty)
                {
                    if (this.IsNewItem)
                        this.MobileService.Contact.SaveContact(this.Item);
                    else
                    {
                        this.MobileService.Contact.SaveContact(this.Item);
                        this.OnDataChanged(this.Item);
                    }

                    // show quick status
                    this.ToastPresenter.Show("Changes saved", ToastDisplayDuration.Immediate);
                }

                this.IsDirty = false;

                // In real world apps, you might want to save changes in batch instead of individual
                // this.ItemRepository.SaveChanges(null, null);

                this.NavigationService.Close(new NavigationResult(NavigationResultAction.Done, this.Item));
            }
            else
                this.ShowErrorMessage();
        }

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            if (parameter.Data != null)
            {
                this.Item = parameter.Data as Contact;

                if (this.Item.Phones.Count > 0)
                    this.Phone = this.Item.Phones[0];

                if (this.Phone == null)
                {
                    this.Phone = new Phone();
                    this.Item.Phones.Add(this.Phone);
                }

                if (this.Item.Emails.Count > 0)
                    this.Email = this.Item.Emails[0];

                if (this.Email == null)
                {
                    this.Email = new Email();
                    this.Item.Emails.Add(this.Email);
                }
            }
            else
            {
                if (this.Item == null)
                {
                    this.Item = new Contact();

                    this.Phone = new Phone();
                    this.Item.Phones.Add(this.Phone);

                    this.Email = new Email();
                    this.Item.Emails.Add(this.Email);

                    this.IsNewItem = true;
                }

                this.Title = "Add New Contact";
            }
        }

        private void ShowErrorMessage()
        {
            // Specifically on Phone devices, present the error to users
            if (this.Context.Platform.OperatingSystem != OSKind.WinRT)
                this.MessagePresenter.Show(this.ErrorMessage);
        }

        #endregion
    }
}