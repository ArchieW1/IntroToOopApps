using System.Drawing;

namespace OopDrawUI
{
    public class Line : Shape
    {
        public Line(Pen pen, int xCoord1, int yCoord1)
            : base(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, XCoord1, YCoord1, XCoord2, YCoord2);
        }
    }
}