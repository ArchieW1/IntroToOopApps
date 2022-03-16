using System.Drawing;
using System.Windows.Forms;

namespace OopDrawUI
{
    public sealed partial class OopDrawForm : Form
    {
        private Pen _currenPen = new Pen(Color.Black);
        private bool _dragging = false;
        private Point _startOfDrag = Point.Empty;
        private Point _lastMousePosition = Point.Empty;
        
        public OopDrawForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void CanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawLine(_currenPen, _startOfDrag, _lastMousePosition);
        }

        private void CanvasPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startOfDrag = e.Location;
            _lastMousePosition = e.Location;
        }

        private void CanvasPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
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