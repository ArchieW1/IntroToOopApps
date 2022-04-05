using System;
using System.Drawing;

namespace OopDrawUI
{
    public class Rectangle : Shape
    {
        public Rectangle(Pen pen, int xCoord1, int yCoord1, int xCoord2, int yCoord2) :
            base(pen, xCoord1, yCoord1, xCoord2, yCoord2)
        {
        }
        
        public Rectangle(Pen pen, int xCoord1, int yCoord1)
            : base(pen, xCoord1, yCoord1, xCoord1, yCoord1)
        {
        }

        public override void Draw(Graphics graphics)
        {
            Tuple<int, int, int, int> measurements = EnclosingRectangle();
            
            int x = measurements.Item1;
            int y = measurements.Item2;
            int width = measurements.Item3;
            int height = measurements.Item4;
            
            graphics.DrawRectangle(Pen, x, y, width, height);
        }

        public override Shape Clone()
        {
            return new Rectangle(Pen, XCoord1, YCoord1, XCoord2, YCoord2);
        }

        public bool FullySurrounds(Shape shape)
        {
            // C# framework tuples make me cry please update school PCs to C# core
            Tuple<int, int, int, int> measurements = EnclosingRectangle();
            Tuple<int, int, int, int> shapeMeasurements = shape.EnclosingRectangle();
            
            int x = measurements.Item1;
            int y = measurements.Item2;
            int width = measurements.Item3;
            int height = measurements.Item4;
            
            int shapeX = shapeMeasurements.Item1;
            int shapeY = shapeMeasurements.Item2;
            int shapeWidth = shapeMeasurements.Item3;
            int shapeHeight = shapeMeasurements.Item4;
            
            return x < shapeY && x < shapeY && x + width > shapeX + shapeWidth && y + height > shapeY + shapeHeight;
        }
    }
}