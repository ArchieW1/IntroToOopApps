﻿using System.Drawing;

namespace OopDrawUI
{
    public abstract class Shape
    {
        public Pen Pen { get; protected set; }
        public int XCoord1 { get; protected set; }
        public int YCoord1 { get; protected set; }
        public int XCoord2 { get; protected set; }
        public int YCoord2 { get; protected set; }
        
        public Shape(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2)
        {
            Pen = pen;
            XCoord1 = xCoord1;
            YCoord1 = yCoord1;
            XCoord2 = xCoord2;
            YCoord2 = yCoord2;
        }
        
        public abstract void Draw(Graphics graphics);
        public void GrowTo(int newXCoord2, int newYCoord2)
        {
            XCoord2 = newXCoord2;
            YCoord2 = newYCoord2;
        }
    }
}