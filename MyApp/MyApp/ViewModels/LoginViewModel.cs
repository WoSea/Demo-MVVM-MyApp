using MvvmHelpers;
using MyApp.Views;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    LoginCommand.ChangeCanExecute();
                }
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    LoginCommand.ChangeCanExecute();
                }
            }
        }


        public Command LoginCommand { get; }

        private readonly INavigation _navigation;
        public LoginViewModel(INavigation navigation)
        {
            LoginCommand = new Command(LoginExecute, CanLogin);

            _navigation = navigation;
        }

        private void LoginExecute()
        {
            if (Username == "K" && Password == "1")
                _navigation.PushAsync(new MainView());
        }

        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }
    }
}
