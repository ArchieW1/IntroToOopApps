using System;
using System.Drawing;

namespace OopDrawUI
{
    public class Rectangle : Shape
    {
        public Rectangle(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2) :
            base(pen, xCoord1, yCoord1, xCoord2, yCoord2)
        {
        }
        
        public Rectangle(Pen pen, int xCoord1, int yCoord1)
            : base(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public override void Draw(Graphics graphics)
        {
            var measurements = EnclosingRectangle();
            graphics.DrawRectangle(Pen,
                measurements.Item1,
                measurements.Item2, 
                measurements.Item3,
                measurements.Item4);
        }
    }
}