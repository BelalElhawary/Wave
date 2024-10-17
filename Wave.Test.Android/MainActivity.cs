using Android;
using Android.App;
using Android.Graphics;
using Android.Views;
using SkiaSharp;
using SkiaSharp.Views.Android;

namespace Wave.Test.Android
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private SKCanvasView SKCanvasView;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var view = FindViewById<SKCanvasView>(Resource.Id.skiaView);
            if (view == null) throw new NullReferenceException("SKCanvasView can't be null.");
            SKCanvasView = view;
        }

        protected override void OnResume()
        {
            base.OnResume();
            SKCanvasView.PaintSurface += OnPaintSurface;
            SKCanvasView.Touch += OnTouchRepaintSurface;
        }

        protected override void OnPause()
        {
            SKCanvasView.PaintSurface -= OnPaintSurface;
            SKCanvasView.Touch -= OnTouchRepaintSurface;
            base.OnPause();
        }

        private void OnTouchRepaintSurface(object sender, View.TouchEventArgs args)
        {
            SKCanvasView.Invalidate();
            args.Handled = true;
        }

        private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            // the the canvas and properties
            var canvas = e.Surface.Canvas;

            // make sure the canvas is blank
            canvas.Clear(SKColors.White);

            var Paint = new SKPaint(new SKFont
            {
                Size = 24
            })
            {
                Color = SKColors.Black,
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                TextAlign = SKTextAlign.Center,
            };

            var Coord = new SKPoint(e.Info.Width / 2, (e.Info.Height + 24) / 2);

            canvas.DrawText("Hello, world ", Coord, Paint);
        }
    }
}