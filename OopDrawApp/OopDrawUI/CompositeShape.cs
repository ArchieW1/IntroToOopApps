using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace OopDrawUI
{
    public class CompositeShape : Shape
    {
        private List<Shape> Components { get; set; }

        public CompositeShape(List<Shape> components) 
            : base(new Pen(Color.Black, 1.0f), 0, 0, 0, 0)
        {
            Pen.DashStyle = DashStyle.Dash;
            Components = components;
            CalculateEnclosingRectangle();
        }
        
        public override void Draw(Graphics graphics)
        {
            foreach (Shape component in Components)
            {
                component.Draw(graphics);
            }

            if (Selected)
            {
                graphics.DrawRectangle(Pen, XCoord1, YCoord1, XCoord2 - XCoord1, YCoord2 - YCoord1);
            }
        }

        public override void MoveBy(int xDelta, int yDelta)
        {
            foreach (Shape component in Components)
            {
                component.MoveBy(xDelta, yDelta);
            }
            
            base.MoveBy(xDelta, yDelta);
        }
        
        private void CalculateEnclosingRectangle()
        {
            XCoord1 = Components.Min(s => Math.Min(s.XCoord1, s.XCoord2));
            YCoord1 = Components.Min(s => Math.Min(s.YCoord1, s.YCoord2));
            XCoord2 = Components.Max(s => Math.Max(s.XCoord1, s.XCoord2));
            YCoord2 = Components.Max(s => Math.Max(s.YCoord1, s.YCoord2));
        }
    }
}