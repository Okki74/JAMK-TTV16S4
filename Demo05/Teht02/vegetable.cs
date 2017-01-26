using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Vegetable
    {
        private string where;
        private string name;
        // Properties
        public string Where
        {
            get { return where; }
            set { where = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // construtors
        public Vegetable() { }
        public Vegetable(string _where, string _name)
        {
           where = _where;
            name = _name;
        }
        // Metohds
        public override string ToString()
        {
            return (" Name:" + Name + " Where: " + where);
        }
    }
}
