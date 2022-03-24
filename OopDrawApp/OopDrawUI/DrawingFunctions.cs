using System.Drawing;

namespace OopDrawUI
{
    public static class DrawingFunctions
    {
        public static void DrawClosedArc(Graphics graphics, Shape shape)
        {
            var measurements = shape.EnclosingRectangle();

            if (measurements.Item3 > 0 && measurements.Item4 > 0)
            {
                graphics.DrawArc(shape.Pen,
                    measurements.Item1,
                    measurements.Item2,
                    measurements.Item3,
                    measurements.Item4,
                    0f,
                    360f);
            }
        }
    }
}
