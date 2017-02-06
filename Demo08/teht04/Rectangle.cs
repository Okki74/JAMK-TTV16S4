using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Rectangle:Shape
    {
        public double AreaMem { get; set; }
        public double CircumferenceMem { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width,double heigth)
        {
            Name = "Rectangle";
            Width = width;
            Height = heigth;
            Area();
            Circumference();
        }

        public override void Area()
        {
            AreaMem = Width * Height;
        }
        public override void Circumference()
        {
            CircumferenceMem = (2*Width) + (2*Height);
        }
        public override string ToString()
        {
            return (" " + Name + " Width: " + Width +" Height: "+Height+" Area: " + AreaMem + " Circumference; " + CircumferenceMem+ "\n");
        }
    }
}
