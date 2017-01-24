using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Bicycle:Vehicle
    {
            private string typeGearing;
            private bool gearing;

        public string TypeGearing
        {
            get { return typeGearing; }
            set { typeGearing = value; }
        }
        public bool Gearing
        {
        get { return gearing; }
        set { gearing = value;}
        }
        public Bicycle() { }
        public Bicycle(string name, string model, string color, int year, string _typeGearing, bool _gearing) {
            Name = name;
            Model = model;
            Color = color;
            Year = year;
            TypeGearing = _typeGearing;
            Gearing = _gearing;
        }
        public override string PrintData()
        {
            return ("Name: " + Name + " Model: " + Model + " Year: " + Year + " Type gearing: " + TypeGearing + " Gearing: " + Gearing);
        }
    }
}
