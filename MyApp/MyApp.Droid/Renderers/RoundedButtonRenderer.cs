using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyApp.Controls;
using MyApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(RoundedButton), typeof(RoundedButtonRenderer))]
namespace MyApp.Droid.Renderers
{
    public class RoundedButtonRenderer : ButtonRenderer
    {
        //private GradientDrawable _normal, _pressed;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var button = (RoundedButton)e.NewElement;

                button.SizeChanged += (s, args) =>
                {
                  
                   var normal = new GradientDrawable();

                    normal.SetColor(button.BackgroundColor.ToAndroid());

                    normal.SetCornerRadius(e.NewElement.BorderRadius);
                        
                    Control.Background = normal;
                };
            }
        }
    }
}
