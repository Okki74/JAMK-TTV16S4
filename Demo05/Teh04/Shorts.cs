using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04
{
    class Shorts:Clothes
    {
        private bool sportShort;
       


        // properties
        public bool SportShirt
        {
            get { return sportShort; }
            set { sportShort = value; }
        }
        public Shorts(bool _sportShort, string _color, double _size, bool _children)
        {
            SportShirt = _sportShort;
            Children = _children;
            color = _color;
            size = _size;
        }


        // methods 
        public override string Color(string _color)
        {
            return _color;
        }
        public override double Size(double _size)
        {
            return _size;
        }
        public override string ToString()
        {
            return (" Sport Shorts:" + sportShort + " Children: " + Children + " Color: " + color + " Size: " + size);
        }
    }
}

