using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppKursovProekt
{
    public partial class FormScene : System.Windows.Forms.Form
    {
        private List<Shape> _shapes = new List<Shape>();
        private Shape _selectedShape = null;
        private bool _isMarked;

        public FormScene()
        {
            InitializeComponent();

            this.SetStyle(
              ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer,
              true);
        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var shape in _shapes)
            {
                shape.Paint(e.Graphics);
            }
        }

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
               
                int order = _shapes
                   .Select(s => s.Order)
                   .OrderBy(o => o)
                   .LastOrDefault() + 1;

                Rectangle rectangle = new Rectangle();
                rectangle.Position = e.Location;
                rectangle.Width = FormRectangle.passingWidth;
                rectangle.Height = FormRectangle.passingHeight;
                rectangle.Color = FormRectangle.passingColorRectangle;
                rectangle.Order = order;
                _shapes.Add(rectangle);
               
                Square square = new Square();
                square.Position = e.Location;
                square.Size = FormSquare.passingSize;
                square.Color = FormSquare.passingColorSquare;
                square.Order = order;
                _shapes.Add(square);

                Circle circle = new Circle();
                circle.Position = e.Location;
                circle.Radius = FormCircle.passingRadius;
                circle.Color = FormCircle.passingColorCircle;
                circle.Order = order;
                _shapes.Add(circle);

                Triangle triangle = new Triangle();
                triangle.Position = e.Location;
                triangle.A = FormTriangle.passingA; 
                triangle.B = FormTriangle.passingB;
                triangle.C = FormTriangle.passingC;
                triangle.Color = FormTriangle.passingColorTriangle;
                triangle.Order = order;
                _shapes.Add(triangle);
              
                using (var graphics = this.CreateGraphics())
                {
                    foreach (var shape in _shapes)
                    {
                        shape.Paint(graphics);
                    }
                }

                _selectedShape = null;

                textBoxSurface.Clear();
                textBoxPerimeter.Clear();
            }

            else if (e.Button == MouseButtons.Right)
            {
                _selectedShape = _shapes
                    .OrderByDescending(o => o.Order)
                    .Where(shape => shape.Contains(e.Location))
                    .FirstOrDefault();

                if (_selectedShape != null)
                {
                    _isMarked = true;

                    textBoxSurface.Text = _selectedShape.CalculateSurface().ToString();
                    textBoxPerimeter.Text = _selectedShape.CalculatePerimeter().ToString();
                }

            }

        }

        private void FormScene_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMarked==true)
            {
                _selectedShape.Position = e.Location;

                using (var graphics = this.CreateGraphics())
                {
                    _selectedShape.Paint(graphics);
                }

              Invalidate();
            }
        }

        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right && _isMarked==true)
            {
                using (var graphics = this.CreateGraphics())
               {
                   _selectedShape.Paint(graphics);
               }

                _isMarked = false;
            
            }
            else if (e.Button == MouseButtons.Right && _isMarked == false)
            {
                _selectedShape = null;

                textBoxSurface.Clear();
                textBoxPerimeter.Clear();
            }

        }
       
        private void btnAddNewShape_Click(object sender, EventArgs e)
        {
            FormRectangle.passingWidth = 0;
            FormRectangle.passingHeight = 0;
            FormSquare.passingSize = 0;
            FormCircle.passingRadius = 0;
            FormTriangle.passingA = 0;
            FormTriangle.passingB = 0;
            FormTriangle.passingC = 0;

            new FormChooseShape().Show();

        }

        private void btnRemoveFromScene_Click(object sender, EventArgs e)
        {
            if (_selectedShape!=null)
            {
                _shapes.Remove(_selectedShape);
                _selectedShape = null;

                textBoxSurface.Clear();
                textBoxPerimeter.Clear();

                Invalidate();
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var binFormatter = new BinaryFormatter();
                string path = saveFileDialog.FileName;
                using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                    binFormatter.Serialize(fileStream, _shapes);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var binFormatter = new BinaryFormatter();
                string path = openFileDialog.FileName;
                using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                _shapes = (List<Shape>)binFormatter.Deserialize(fileStream);
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("При натискане на ляв бутон на мишката върху сцената, изрисувате желаната от вас фигура. \n" + 
                "При натискане на десен бутон на мишката върху дадена фигура, тя се избира и може да бъде изтрита и се получaва нформация за нейното лице и периметър. \n" +
                "При натискане на десен бутон на мишката върху дадена фигура и влачене, фигурата се мести. \n" +
                "Една фигура се счита за избрана, докато не спре да се показва информация за нейното лице и периметър. \n"+
                "При зареждане на файл, сцената трябва да се минимализира и прозорецът да се отвори отново.");
        }

    }
}
