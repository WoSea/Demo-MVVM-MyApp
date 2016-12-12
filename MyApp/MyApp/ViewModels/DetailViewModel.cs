

using MvvmHelpers;
using MyApp.Models;

namespace MyApp.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        private Contact _contact;

        public Contact Contact

        {
            get { return _contact; }
            set
            {
                //if (_contact != value)
                //{
                //    _contact = value;
                //    OnPropertyChanged(nameof(Contact));
                //}

                SetProperty(ref _contact, value);
            }
        }

        public DetailViewModel()
        {

        }

        public void SetData(Contact contact)
        {
            Contact = contact;

            Title = contact.FullName;
        }
    }
}
