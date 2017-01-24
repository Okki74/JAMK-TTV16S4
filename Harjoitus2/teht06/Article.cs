using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Article
    {
        private string name;
        private string manifacture;
        private int standNum;

        public Article() { }
        public Article (string _name, string _manifacture, int _standNum)
        {
            name=_name;
            manifacture = _manifacture;
            standNum = _standNum;
        } 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Manifacture
        {
            get { return manifacture; }
            set { manifacture = value; }
        }
        public int StandNum
        {
            get { return standNum; }
            set { standNum = value; }
        }
        public virtual string PrintData()
        {
            return ("Name: " + Name + " Manifacture: " + Manifacture + " Stand: " + StandNum);
        }
    }
}
