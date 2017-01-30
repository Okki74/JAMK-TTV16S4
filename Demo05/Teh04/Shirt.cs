using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04
{
    class Shirt:Clothes
    {
        private bool partyShirt;
        private string manufacture;

        
        // properties
        public bool PartyShirt
        {
            get { return partyShirt; }
            set { partyShirt = value; }
        }


        public string Manufacture
        {
            get { return manufacture; }
            set { manufacture = value; }
        }
        public Shirt (bool _partyshirt,string _manufacture, string _color,double _size, bool _children)
        {
            PartyShirt = _partyshirt;
            Manufacture = _manufacture;
            Children = _children;
            color=_color;
            size=_size;
        }
         // methods 
    public override string Color(string _color)
        {
            color = _color;
            return color;
        }
     public override double Size(double _size)
        {
            size = _size;
            return size;
        }
        public override string ToString()
        {
            return (" Party Shirt:" + partyShirt + " Manifacture: " + Manufacture+ " Children: " +Children+" Color: "+color+" Size: "+size);
        }
    }
}
