using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OopDrawUI
{
    public sealed partial class OopDrawForm : Form
    {
        private Pen _currentPen = new Pen(Color.Black);
        private bool _dragging;
        private readonly List<Shape> _shapes = new List<Shape>();
        
        public OopDrawForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            WidthComboBox.SelectedItem = "Medium";
            ColourComboBox.SelectedItem = "Green";
            ShapeComboBox.SelectedItem = "Line";
        }

        private void CanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (Shape shape in _shapes)
            {
                shape.Draw(graphics);
            }
        }

        private void CanvasPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _shapes.Add(new Line(_currentPen, e.X, e.Y));
            switch (ShapeComboBox.Text)
            {
                case "Line":
                    _shapes.Add(new Line(_currentPen, e.X, e.Y));
                    break;
                case "Rectangle":
                    _shapes.Add(new Rectangle(_currentPen, e.X, e.Y));
                    break;
            }
        }

        private void CanvasPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Shape shape = _shapes.Last();
                shape.GrowTo(e.X, e.Y);
                Refresh();
            }
        }

        private void CanvasPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void WidthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            float width = _currentPen.Width;
            switch (WidthComboBox.Text)
            {
                case "Thin":
                    width = 2.0f;
                    break;
                case "Medium":
                    width = 4.0f;
                    break;
                case "Thick":
                    width = 8.0f;
                    break;
            }
            _currentPen = new Pen(_currentPen.Color, width);
        }

        private void ColourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color colour = _currentPen.Color;
            switch (ColourComboBox.Text)
            {
                case "Black":
                    colour = Color.Black;
                    break;
                case "Red":
                    colour = Color.Red;
                    break;
                case "Blue":
                    colour = Color.Blue;
                    break;
                case "Green":
                    colour = Color.Green;
                    break;
            }
            _currentPen = new Pen(colour, _currentPen.Width);
        }
    }
}