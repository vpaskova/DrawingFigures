using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppKursovProekt
{
   [Serializable]
    public class Circle:Shape
    {
        private float radius;
        private float PI= (float)Math.PI;
        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public override void Paint(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black, 2);
            graphics.DrawEllipse(pen, Position.X-Radius, Position.Y-Radius, Radius*2, Radius*2);

            SolidBrush brush = new SolidBrush(Color);
            graphics.FillEllipse(brush, Position.X-Radius, Position.Y-Radius, Radius * 2, Radius * 2);
        }
        public override float CalculateSurface()
        {
            return Radius * Radius * PI ; 
        }
        public override float CalculatePerimeter()
        {
            return 2 * PI * Radius;
        }
        public override bool Contains(Point point)
        {
            return
                (point.X - Position.X)* (point.X - Position.X)+(point.Y - Position.Y)*(point.Y - Position.Y) < Radius * Radius;
        }
    }
}
