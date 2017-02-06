using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class product
    {
        private string name;
        private double price;      

        public double Price { get { return price; }set { price = value; } }
        public string Name { get { return name; }set { name = value; } }

        public product (string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }

        public override string ToString()
        {
            return ("-product "+Name+"  "+Price+" Euro");
        }



    }
}
