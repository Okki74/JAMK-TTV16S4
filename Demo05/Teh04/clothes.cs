using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04
{
    abstract class Clothes
    {
        public double size;
        public string color;
        public bool Children { get;set;}

        public abstract double Size( double _size);
        public abstract string Color(string _color);
    }
}
