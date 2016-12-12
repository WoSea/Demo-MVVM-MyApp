using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;
using MyApp.ViewModels;
using Xamarin.Forms;

namespace MyApp.Views
{
    public partial class DetailView : ContentPage
    {
       
        public DetailViewModel ViewModel { get; }

        public DetailView(Contact contact)
        {
            InitializeComponent();

            BindingContext = ViewModel = new DetailViewModel();

            ViewModel.SetData(contact);
        }
    }
}
