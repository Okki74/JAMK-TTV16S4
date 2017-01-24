using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Book:Article
    {
        private int pages;
        private string types;

        public Book (string name, string manifacture, int standNum, int _pages, string _type)
        {
            Name = name;
            Manifacture = manifacture;
            StandNum = standNum;
            pages = _pages;
            types = _type;
        }
        public string Types
        {
            get { return types; }
            set { types = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public override string PrintData()
        {
            return ("Name: " + Name + " Manifacture: " + Manifacture + " Stand: " + StandNum+" Pages: "+Pages+" Type: "+Types);
        }
    }
}
