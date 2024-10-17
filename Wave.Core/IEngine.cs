using SkiaSharp;

namespace Wave.Core
{
    public interface IEngine
    {
        public void PaintSurface(SKSurface surface, SKImageInfo info);
    }
}
