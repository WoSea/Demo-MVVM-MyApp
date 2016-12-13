
using System.Reflection;
using Android.Graphics.Drawables;
using MyApp.Controls;
using MyApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyButton), typeof(MyButtonRenderer))]
namespace MyApp.Droid.Renderers
{
    public class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var button = (MyButton) e.NewElement;
                var background = button.BackgroundColor.ToAndroid();

                var drawable = new GradientDrawable();
                drawable.SetColor(background);
                drawable.SetCornerRadius(button.BorderRadius);

                Control.Background = drawable;
            }
        }
    }
}