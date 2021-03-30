using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppKursovProekt
{
    [Serializable]
    public class Square:Shape
    {
        private float size;
        public float Size
        {
            get { return size; }
            set { size = value; }
        }

        public override void Paint(Graphics graphics)
        {           
            Pen pen = new Pen(Color.Black, 2);
            graphics.DrawRectangle(pen, Position.X, Position.Y,Size,Size);

            SolidBrush brush = new SolidBrush(Color);
            graphics.FillRectangle(brush, Position.X, Position.Y, Size, Size);
        }
        public override float CalculateSurface()
        {
            return Size*Size;

        }
        public override float CalculatePerimeter()
        {
            return 4 * Size;
        }
        public override bool Contains(Point point)
        {
            return
              Position.X < point.X && point.X < Position.X + Size &&
              Position.Y < point.Y && point.Y < Position.Y +Size;
        }

    }
}
