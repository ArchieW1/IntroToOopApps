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
        private Point _startOfDrag;
        private Point _lastMousePosition;
        private Rectangle _selectionBox;

        public OopDrawForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            WidthComboBox.SelectedItem = "Medium";
            ColourComboBox.SelectedItem = "Green";
            ShapeComboBox.SelectedItem = "Line";
            ActionComboBox.SelectedItem = "Draw";
        }

        private void CanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (Shape shape in _shapes)
            {
                shape.Draw(graphics);
            }

            _selectionBox?.Draw(graphics);
        }

        private void CanvasPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startOfDrag = _lastMousePosition = e.Location;
            switch (ActionComboBox.Text)
            {
                case "Draw":
                    AddShape(e);
                    break;
                case "Select":
                    Pen pen = new Pen(Color.Black, 1.0f);
                    _selectionBox = new Rectangle(pen, _startOfDrag.X, _startOfDrag.Y);
                    break;
            }
        }

        private void CanvasPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                switch (ActionComboBox.Text)
                {
                    case "Move":
                        MoveSelectedShapes(e);
                        break;
                    case "Draw":
                        Shape shape = _shapes.Last();
                        shape.GrowTo(e.X, e.Y);
                        break;
                    case "Select":
                        _selectionBox.GrowTo(e.X, e.Y);
                        SelectShapes();
                        break;
                }
                _lastMousePosition = e.Location;
                Refresh();
            }
        }

        private void CanvasPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
            _lastMousePosition = Point.Empty;
            _selectionBox = null;
            Refresh();
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

        private void ActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ActionComboBox.Text)
            {
                case "Group":
                    GroupSelectedShapes();
                    break;
                case "Delete":
                    DeleteSelectedShapes();
                    break;
            }
        }
        
        private void AddShape(MouseEventArgs e)
        {
            switch (ShapeComboBox.Text)
            {
                case "Line":
                    _shapes.Add(new Line(_currentPen, e.X, e.Y));
                    break;

                case "Rectangle":
                    _shapes.Add(new Rectangle(_currentPen, e.X, e.Y));
                    break;

                case "Ellipse":
                    _shapes.Add(new Ellipse(_currentPen, e.X, e.Y));
                    break;

                case "Circle":
                    _shapes.Add(new Circle(_currentPen, e.X, e.Y));
                    break;
            }
        }

        private void DeselectAll()
        {
            foreach (Shape shape in _shapes)
            {
                shape.Deselect();
            }
        }

        private void SelectShapes()
        {
            DeselectAll();
            IEnumerable<Shape> surroundedShapes = _shapes.Where(shape => _selectionBox.FullySurrounds(shape));
            foreach (Shape shape in surroundedShapes)
            {
                shape.Select();
            }
        }

        private List<Shape> GetSelectedShapes()
        {
            return _shapes.Where(s => s.Selected).ToList();
        }

        private void MoveSelectedShapes(MouseEventArgs e)
        {
            foreach (Shape shape in GetSelectedShapes())
            {
                shape.MoveBy(e.X - _lastMousePosition.X, e.Y - _lastMousePosition.Y);
            }
        }

        private void GroupSelectedShapes()
        {
            List<Shape> members = GetSelectedShapes();
            if (members.Count < 2)
            {
                return;
            }

            CompositeShape compositeShape = new CompositeShape(members);
            compositeShape.Select();
            _shapes.Add(compositeShape);
            foreach (Shape member in members)
            {
                _shapes.Remove(member);
                member.Deselect();
            }
            Refresh();
        }

        private void DeleteSelectedShapes()
        {
            foreach (Shape selectedShape in GetSelectedShapes())
            {
                _shapes.Remove(selectedShape);
            }
            Refresh();
        }
    }
}