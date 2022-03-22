using System;
using System.Drawing;

namespace OopDrawUI
{
    public class Rectangle : Shape
    {
        public Rectangle(Pen pen, int xCoord1, int yCoord1) 
            : base(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public override void Draw(Graphics graphics)
        {
            int xCoord = Math.Min(XCoord1, XCoord2);
            int yCoord = Math.Min(YCoord1, YCoord2);
            int width = Math.Max(XCoord1, XCoord2) - xCoord;
            int height = Math.Max(YCoord1, YCoord2) - yCoord;
            graphics.DrawRectangle(Pen, xCoord, yCoord, width, height);
        }
    }
}