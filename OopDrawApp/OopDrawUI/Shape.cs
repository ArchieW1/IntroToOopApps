using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace OopDrawUI
{
    public abstract class Shape
    {
        public Pen Pen { get; protected set; }
        public int XCoord1 { get; protected set; }
        public int YCoord1 { get; protected set; }
        public int XCoord2 { get; protected set; }
        public int YCoord2 { get; protected set; }
        public bool Selected { get; private set; }

        public Shape(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2)
        {
            Pen = new Pen(pen.Color, pen.Width);
            XCoord1 = xCoord1;
            YCoord1 = yCoord1;
            XCoord2 = xCoord2;
            YCoord2 = yCoord2;
        }

        public abstract void Draw(Graphics graphics);

        public Tuple<int, int, int, int> EnclosingRectangle()
        {
            int xCoord = Math.Min(XCoord1, XCoord2);
            int yCoord = Math.Min(YCoord1, YCoord2);
            int width = Math.Max(XCoord1, XCoord2) - xCoord;
            int height = Math.Max(YCoord1, YCoord2) - yCoord;
            return new Tuple<int, int, int, int>(xCoord, yCoord, width, height);
        }

        public void GrowTo(int newXCoord2, int newYCoord2)
        {
            XCoord2 = newXCoord2;
            YCoord2 = newYCoord2;
        }

        public virtual void MoveBy(int xDelta, int yDelta)
        {
            XCoord1 += xDelta;
            YCoord1 += yDelta;
            XCoord2 += xDelta;
            YCoord2 += yDelta;
        }

        public void Select()
        {
            Selected = true;
            Pen.DashStyle = DashStyle.Dash;
        }

        public void Deselect()
        {
            Selected = false;
            Pen.DashStyle = DashStyle.Solid;
        }

        public abstract Shape Clone();
    }
}