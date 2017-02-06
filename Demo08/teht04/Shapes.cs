using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Shapes
    {
        public List<Circle> circles;
        public List<Rectangle> rectangles;

        public Shapes()
        {
            circles = new List<Circle>();
            rectangles = new List<Rectangle>();
        }
        public void AddCircle(double radius)
        {
            circles.Add(new Circle(radius));
        }
        public void AddRectangle(double width,double height)
        {
            rectangles.Add(new Rectangle(width, height));
        }
        public override string ToString()
        {
            string str=null;
            foreach (Circle c in circles)
            {
                str += (c.ToString());
            }
            foreach (Rectangle r in rectangles)
            {
                str += (r.ToString());
            }
            return str;
        }
    }
}
