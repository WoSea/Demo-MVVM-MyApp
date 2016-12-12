using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.ViewModels;
using Xamarin.Forms;

namespace MyApp.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

            BindingContext = new LoginViewModel(Navigation);

            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}
