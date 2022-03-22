using System.Drawing;

namespace OopDrawUI
{
    public abstract class Shape
    {
        public Pen Pen { get; private set; }
        public int XCoord1 { get; private set; }
        public int YCoord1 { get; private set; }
        public int XCoord2 { get; private set; }
        public int YCoord2 { get; private set; }
        public abstract void Draw(Graphics graphics);
        public abstract void GrowTo(int newXCoord2, int newYCoord2);
    }
}