using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Vehicle
    {
        private string name;
        private string model;
        private string color;
        private int year;

        public Vehicle () { }
        public Vehicle (string _name,string _model,string _color,int _year)
        {
            name = _name;
            model = _model;
            color=_color;
            year = _year;
        }
        public string Name {
            get { return name; }
            set { name = value; }
    }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public virtual string PrintData()
        {
            return ("Name: " + name + " Model: " + model + " Year: " + year);
        }
    }
}
