using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppKursovProekt
{
    [Serializable]
    public abstract class Shape
    {
        private Point position;
        private Color color;
        private int order;

        public Point Position 
        {
            get {return position;}
            set {position = value;}
        }
        public Color Color 
        {  
            get {return color;}
            set {color = value;}
           
        }
        public int Order
        {
            get {return order;}
            set {order = value;}
        }
        public abstract void Paint(Graphics graphics);
        public abstract float CalculateSurface();
        public abstract float CalculatePerimeter();
        public abstract bool Contains(Point point);
       
   
        
    }
}
