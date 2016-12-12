using MyApp.ViewModels;
using Xamarin.Forms;

namespace MyApp.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel(Navigation);
        }
    }
}
