using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Circle:Shape
    {
        public double AreaMem { get; set; }
        public double CircumferenceMem { get; set; }
        public double Radius { get; set; }
       

        public Circle (double radius)
        {
            Name = "Circle";
            Radius = radius;
            Area();
            Circumference();
        }

        public override void Area()
        {
            AreaMem = 3.14 * (Radius*Radius);
        }
        public override void Circumference()
        {
            CircumferenceMem = (2 * 3.14)*Radius;
        }
        public override string ToString()
        {
            return (" " + Name + " Radius: " + Radius + " Area: " + AreaMem + " Circumference; " + CircumferenceMem+"\n");
        }
    }
}
