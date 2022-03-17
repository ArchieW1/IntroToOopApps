using System.Drawing;

namespace OopDrawUI
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics);
        public abstract void GrowTo(int newXCoord2, int newYCoord2);
    }
}