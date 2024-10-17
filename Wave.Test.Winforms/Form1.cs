using SkiaSharp;

namespace Wave.Test.Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void skControl1_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
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
