using System.Drawing;

namespace OopDrawUI
{
    public class Line
    {
        public Pen Pen { get; private set; }
        public int XCoord1 { get; private set; }
        public int YCoord1 { get; private set; }
        public int XCoord2 { get; private set; }
        public int YCoord2 { get; private set; }

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

        public void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, XCoord1, YCoord1, XCoord2, YCoord2);
        }

        public void GrowTo(int newXCoord2, int newYCoord2)
        {
            XCoord2 = newXCoord2;
            YCoord2 = newYCoord2;
        }
    }
}