using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Food
    {
        private string manifacture;
        private string name;
        // Properties
        public string Manifacture
        {
            get { return manifacture; }
            set { manifacture = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // construtors
        public Food() { }
        public Food(string _manifacture, string _name) 
        {
            manifacture = _manifacture;
            name = _name;
        }
        // Metohds
        public override string ToString()
        {
            return (" Name:" + Name + " Manifacture: " + Manifacture);
        }
    }
}
