using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OopDrawUI
{
    public sealed partial class OopDrawForm : Form
    {
        private Pen _currenPen = new Pen(Color.Black);
        private bool _dragging = false;
        private Point _startOfDrag = Point.Empty;
        private Point _lastMousePosition = Point.Empty;
        private List<Line> _lines = new List<Line>();
        
        public OopDrawForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void CanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (Line line in _lines)
            {
                line.Draw(graphics);
            }
        }

        private void CanvasPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startOfDrag = e.Location;
            _lastMousePosition = e.Location;
            _lines.Add(new Line(_currenPen, e.X, e.Y));
        }

        private void CanvasPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Line currentLine = _lines.Last();
                currentLine.GrowTo(e.X, e.Y);
                _lastMousePosition = e.Location;
                Refresh();
            }
        }

        private void CanvasPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}