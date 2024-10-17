using Android;
using Android.App;
using SkiaSharp;
using SkiaSharp.Views.Android;

namespace Wave.Test.Android
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private SKCanvasView SKCanvas;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            SKCanvas = FindViewById<SKCanvasView>(Resource.Id.skiaView);
        }
    }
}