using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApp.Controls
{
    public partial class ImageEntry : ContentView
    {


        public static readonly BindableProperty HintProperty =
            BindableProperty.Create(nameof(Hint), typeof(string), typeof(ImageEntry), default(string));

        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public static readonly BindableProperty ImageSourceProperty =
        BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(ImageEntry), default(string));

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }


        public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(ImageEntry), default(string), BindingMode.TwoWay);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public static readonly BindableProperty IsPassProperty =
        BindableProperty.Create(nameof(IsPass), typeof(bool), typeof(ImageEntry), default(bool));

        public bool IsPass
        {
            get { return (bool)GetValue(IsPassProperty); }
            set { SetValue(IsPassProperty, value); }
        }
        public ImageEntry()
        {
            InitializeComponent();

            RootGrid.BindingContext = this;
        }
    }
}
