using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Phone:Article
    {
        private bool smathphone;
        private string platfrm;

        public Phone(string name, string manifacture, int standNum, bool _smathphone, string _platfrm)
        {
            Name = name;
            Manifacture = manifacture;
            StandNum = standNum;
            smathphone = _smathphone;
            platfrm = _platfrm;
        }
        public string Platfrm
        {
            get { return platfrm; }
            set { platfrm = value; }
        }
        public bool Smathphone
        {
            get { return smathphone; }
            set { smathphone = value; }
        }
        public override string PrintData()
        {
            return ("Name: " + Name + " Manifacture: " + Manifacture + " Stand: " + StandNum + " Smarthphone: " + Smathphone + " Platform: " + Platfrm);
        }
    }
}
