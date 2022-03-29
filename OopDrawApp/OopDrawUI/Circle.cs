using System;
using System.Drawing;

namespace OopDrawUI
{
    public class Circle : Shape
    {
        public Circle(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2)
            : base(pen, xCoord1, yCoord1, xCoord2, yCoord2)
        {
        }
        
        public Circle(Pen pen, int xCoord1, int yCoord1)
            : base(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public override void Draw(Graphics graphics)
        {
            DrawingFunctions.DrawClosedArc(graphics, this);
        }

        public new virtual void GrowTo(int xCoord2, int yCoord2)
        {
            int diameter = Math.Max(xCoord2 - XCoord1, yCoord2 - YCoord1);

            XCoord2 = XCoord1 + diameter;
            YCoord2 = YCoord1 + diameter;
        }
    }
}
