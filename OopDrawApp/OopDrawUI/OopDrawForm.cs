using System.Drawing;
using System.Windows.Forms;

namespace OopDrawUI
{
    public sealed partial class OopDrawForm : Form
    {
        private Pen _currenPen = new Pen(Color.Black);
        
        public OopDrawForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void CanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Point pointA = new Point(0, 0);
            Point pointB = new Point(0, 400);
            Point pointC = new Point(500, 200);
            graphics.DrawLine(_currenPen, pointA, pointB);
            graphics.DrawLine(_currenPen, pointB, pointC);
            graphics.DrawLine(_currenPen, pointC, pointA);
        }
    }
}