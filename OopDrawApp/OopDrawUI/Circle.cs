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
            int xCoord = Math.Min(XCoord1, XCoord2);
            int yCoord = Math.Min(YCoord1, YCoord2);
            int width = Math.Max(XCoord1, XCoord2) - xCoord;
            int height = Math.Max(YCoord1, YCoord2) - yCoord;

            if (width > 0 && height > 0)
            {
                graphics.DrawArc(Pen, xCoord, yCoord, width, height, 0f, 360f);
            }
        }

        public new virtual void GrowTo(int xCoord2, int yCoord2)
        {
            int diameter = Math.Max(xCoord2 - XCoord1, yCoord2 - YCoord1);

            XCoord2 = XCoord1 + diameter;
            YCoord2 = YCoord1 + diameter;
        }
    }
}
