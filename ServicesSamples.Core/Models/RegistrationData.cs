namespace ServicesSamples.Models
{
    public class RegistrationData : ModelBase
    {
        #region Constructors

        public RegistrationData()
        {
        }

        #endregion

        #region Fields

        private string _confirmEmail;
        private string _contact;
        private string _email;
        private bool _isAgree;
        private string _name;
        private string _password;

        #endregion

        #region Properties

        public string ConfirmEmail
        {
            get { return _confirmEmail; }
            set
            {
                if (_confirmEmail != value)
                {
                    _confirmEmail = value;
                    OnPropertyChanged("ConfirmEmail");
                }
            }
        }

        public string Contact
        {
            get { return _contact; }
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged("Contact");
                }
            }
        }

        public string Email
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

        public bool IsAgree
        {
            get { return _isAgree; }
            set
            {
                if (_isAgree != value)
                {
                    _isAgree = value;
                    OnPropertyChanged("IsAgree");
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        #endregion
    }
}