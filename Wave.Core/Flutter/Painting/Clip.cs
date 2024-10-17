using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Core.Flutter.Painting
{
    internal enum Clip
    {
        None,
        HardEdge,
        AntiAlias,
        AntiAliasWithSaveLayer
    }

    internal abstract class ClipContext
    {
        public SKCanvas Canvas { get; }

        private void ClipAndPaint(Action<bool> canvasClipCall, Clip clipBehavior, SKRect bounds, Action painter)
        {
            Canvas.Save();
            switch (clipBehavior)
            {
                case Clip.None:
                    break;
                case Clip.HardEdge:
                    canvasClipCall(false);
                    break;
                case Clip.AntiAlias:
                    canvasClipCall(true);
                    break;
                case Clip.AntiAliasWithSaveLayer:
                    canvasClipCall(true);
                    Canvas.SaveLayer(bounds, new SKPaint());
                    break;
            }
            painter();
            if(clipBehavior == Clip.AntiAliasWithSaveLayer) {
                Canvas.Restore();
            }
            Canvas.Restore();
        }

        private void ClipPathAndPaint(SKPath path, Clip clipBehavior, SKRect bounds, Action painter)
        {
            ClipAndPaint((doAntiAlias) => Canvas.ClipPath(path, antialias: doAntiAlias), clipBehavior, bounds, painter);
        }

        private void ClipRRectAndPaint(SKRoundRect roundRect, Clip clipBehavior, SKRect bounds, Action painter)
        {
            ClipAndPaint((doAntiAlias) => Canvas.ClipRoundRect(roundRect, antialias: doAntiAlias), clipBehavior, bounds, painter);
        }

        private void ClipRectAndPaint(SKRect rect, Clip clipBehavior, SKRect bounds, Action painter)
        {
            ClipAndPaint((doAntiAlias) => Canvas.ClipRect(rect, antialias: doAntiAlias), clipBehavior, bounds, painter);
        }
    }
}
