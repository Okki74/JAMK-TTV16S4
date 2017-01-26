using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Drink
    {
        private string manifacture;
        private string type;
        // Properties
        public string Manifacture
        {
            get { return manifacture; }
            set { manifacture = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        // construtors
        public Drink() { }
        public Drink (string _manifacture,string _type)
        {
            manifacture = _manifacture;
            type = _type;
        }
        // Metohds
        public override string ToString()
        {
            return (" Name:" + Type + " Manifacture: " + Manifacture);
        }
    }
}
