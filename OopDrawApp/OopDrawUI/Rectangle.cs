﻿using System;
using System.Drawing;

namespace OopDrawUI
{
    public class Rectangle
    {
        public Pen Pen { get; private set; }
        public int XCoord1 { get; private set; }
        public int YCoord1 { get; private set; }
        public int XCoord2 { get; private set; }
        public int YCoord2 { get; private set; }

        public Rectangle(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2)
        {
            Pen = pen;
            XCoord1 = xCoord1;
            YCoord1 = yCoord1;
            XCoord2 = xCoord2;
            YCoord2 = yCoord2;
        }
        
        public Rectangle(Pen pen, int xCoord1, int yCoord1) 
            : this(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public void Draw(Graphics graphics)
        {
            int xCoord = Math.Min(XCoord1, XCoord2);
            int yCoord = Math.Min(YCoord1, YCoord2);
            int width = Math.Max(XCoord1, XCoord2) - xCoord;
            int height = Math.Max(YCoord1, YCoord2) - yCoord;
            graphics.DrawRectangle(Pen, xCoord, yCoord, width, height);
        }
        
        public void GrowTo(int newXCoord2, int newYCoord2)
        {
            XCoord2 = newXCoord2;
            YCoord2 = newYCoord2;
        }
    }
}