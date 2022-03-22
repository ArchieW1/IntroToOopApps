using System.Drawing;

namespace OopDrawUI
{
    public class Line : Shape
    {
        public Line(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2)
        {
            Pen = pen;
            XCoord1 = xCoord1;
            YCoord1 = yCoord1;
            XCoord2 = xCoord2;
            YCoord2 = yCoord2;
        }

        public Line(Pen pen, int xCoord1, int yCoord1) 
            : this(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, XCoord1, YCoord1, XCoord2, YCoord2);
        }

        public override void GrowTo(int newXCoord2, int newYCoord2)
        {
            XCoord2 = newXCoord2;
            YCoord2 = newYCoord2;
        }
    }
}