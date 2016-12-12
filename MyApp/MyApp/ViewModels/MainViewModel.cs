

using System.Collections.Generic;
using MvvmHelpers;
using MyApp.Models;
using MyApp.Views;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Contact _contactSelected;
        public List<Contact> Contacts { get; set; }

        public Contact ContactSelected
        {
            get { return _contactSelected; }
            set
            {
                if (_contactSelected != value)
                {
                    _contactSelected = value;

                    if (_contactSelected != null)
                    {
                        _navigation.PushAsync(new DetailView(_contactSelected));
                    }
                }
            }
        }

        private INavigation _navigation;

        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;

            Contacts = new List<Contact>(Data.Get());

            Title = "MyApp";
        }
    }
}
