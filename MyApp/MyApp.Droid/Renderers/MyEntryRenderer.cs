using Android.Graphics.Drawables;
using Android.Views;
using MyApp.Controls;
using MyApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MyColor = Android.Graphics.Color;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace MyApp.Droid.Renderers
{
    public class MyEntryRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

                var drawable = new GradientDrawable();
            
                drawable.SetColor(MyColor.White);
                drawable.SetCornerRadius(20);

                Control.Gravity = GravityFlags.CenterVertical;
                Control.Background = drawable;
            }
        }
    }
}