using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppKursovProekt
{
    [Serializable]
   public class Rectangle:Shape
    {
        private float height;
        private float width;

        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
        public override void Paint(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black, 2);          
            graphics.DrawRectangle(pen, Position.X, Position.Y, Width, Height);

            SolidBrush brush = new SolidBrush(Color);
            graphics.FillRectangle(brush, Position.X, Position.Y, Width, Height);
        }

        public override float CalculateSurface()
        {
          return Height * Width;
        }
        public override float CalculatePerimeter()
        {
            return 2 * Width + 2 * Height;
        }
        public override bool Contains(Point point)
        {
            return
            Position.X < point.X && point.X < Position.X + Width &&
            Position.Y < point.Y && point.Y < Position.Y + Height;
        }
    }
}
