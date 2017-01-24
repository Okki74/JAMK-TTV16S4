using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class DigitalSheet:Article
    {
        private string type;
        private int capasetive;
        private bool used;

        public DigitalSheet() { }
        public DigitalSheet(string name, string manifacture, int standNum,string _type, int _capasit, bool _used)
        {
            Name = name;
            Manifacture = manifacture;
            StandNum = standNum;
            type = _type;
            capasetive = _capasit;
            used = _used;
        }
        public int Capasetive
        {
            get { return capasetive; }
            set { capasetive = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public bool Used
        {
            get { return used; }
            set { used = value; }
        }
        public override string PrintData()
        {
            return ("Name: " + Name + " Manifacture: " + Manifacture + " Stand: " + StandNum +" Type: "+Type+" Used: " + used + " Capasitive " + Capasetive+" Gb");
        }
    }
}
