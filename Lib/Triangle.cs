using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppKursovProekt
{
    [Serializable]
    public class Triangle:Shape

    {
        private float a;
        private float b;
        private float c;
        public float A
        {
            get { return a; }
            set { a = value; }
        }
        public float B
        {
            get { return b; }
            set { b = value; }
        }
        public float C
        {
            get { return c; }
            set { c = value; }
        }
        private float hc;
        private float Hc
        {
            get { return 2 * CalculateSurface() / C; }
            set { hc = value; }

        }
        public override void Paint(Graphics graphics)
        {
            float x = (float)Math.Sqrt(B * B - Hc * Hc);

            Pen pen = new Pen(Color.Black, 2);
            PointF[] pointF = 
            {new PointF(Position.X, Position.Y),new PointF(Position.X+C, Position.Y), new PointF(Position.X+x,Position.Y-Hc) };
            graphics.DrawPolygon(pen, pointF);

            SolidBrush brush = new SolidBrush(Color);
            graphics.FillPolygon(brush, pointF);
        }
        public override float CalculateSurface()
        {        
            float area =(float)Math.Sqrt((A + B + C)/2 * (B + C - A)/2 * (A + C - B)/2 * (A + B - C)/2);
            return area;
        }
        public override float CalculatePerimeter()
        {
            return A + B + C;
        }
        public override bool Contains(Point point)
        {
            float x = (float)Math.Sqrt(B * B - Hc * Hc);

            float l1 = (point.X - Position.X) * ((Position.Y - Hc) - Position.Y) - (Position.X + x - Position.X) * (point.Y - Position.Y);
            float l2 = (point.X - (Position.X + C)) * (Position.Y - Position.Y) - (Position.X - (Position.X + C)) * (point.Y - Position.Y);
            float l3 = (point.X - (Position.X + x)) * (Position.Y - (Position.Y - Hc)) - ((Position.X + C) - (Position.X + x)) * (point.Y - (Position.Y - Hc));
            return 
                (l1 > 0 && l2 > 0 && l3 > 0) || (l1 < 0 && l2 < 0 && l3 < 0);
        }
    }
}
