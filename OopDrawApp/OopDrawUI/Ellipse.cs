using System;
using System.Drawing;

namespace OopDrawUI
{
    public class Ellipse : Shape
    {
        public Ellipse(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2) 
            : base(pen, xCoord1, yCoord1, xCoord2, yCoord2)
        {
        }

        public override void Draw(Graphics graphics)
        {
            int xCoord = Math.Min(XCoord1, XCoord2);
            int yCoord = Math.Min(YCoord1, YCoord2);
            int width = Math.Max(XCoord1, XCoord2) - xCoord;
            int height = Math.Max(YCoord1, YCoord2) - yCoord;
            graphics.DrawArc(Pen, xCoord, yCoord, width, height, 0f, 360f);
        }
    }
}