using System.Drawing;

namespace OopDrawUI
{
    public class Line : Shape
    {
        public Line(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2) :
            base(pen, xCoord1, yCoord1, xCoord2, yCoord2)
        {
        }
        
        public Line(Pen pen, int xCoord1, int yCoord1)
            : base(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, XCoord1, YCoord1, XCoord2, YCoord2);
        }

        public Line Clone()
        {
            return new Line(Pen, XCoord1, YCoord1, XCoord2, YCoord2);
        }
    }
}