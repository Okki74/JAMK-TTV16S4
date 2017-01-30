using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04
{
    class Trousers:Clothes
    {
        private bool suitTrousers;
       


        // properties
        public bool SuitTrousers
        {
            get { return suitTrousers; }
            set { suitTrousers = value; }
        }
        public Trousers(bool _suitTrousers, string _color, double _size, bool _children)
        {
            SuitTrousers = _suitTrousers;
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
        return (" Suit Trousers:" + suitTrousers + " Children: " + Children + " Color: " + color + " Size: " + size);
    }
    }
}
