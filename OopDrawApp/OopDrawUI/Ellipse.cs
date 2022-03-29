using System.Drawing;

namespace OopDrawUI
{
    public class Ellipse : Shape
    {
        public Ellipse(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2) 
            : base(pen, xCoord1, yCoord1, xCoord2, yCoord2)
        {
        }
        
        public Ellipse(Pen pen, int xCoord1, int yCoord1)
            : base(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public override void Draw(Graphics graphics)
        {
            DrawingFunctions.DrawClosedArc(graphics, this);
        }
    }
}