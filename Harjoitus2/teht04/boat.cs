using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Boat : Vehicle
    {
        private string style;
        private int seat;
   

    public int Seat {
        get { return seat; }
        set { seat = value; }
    }
    public string Style
        {
            get { return style; }
            set { style = value; }
        }
        public Boat() { }
        public Boat(string _name, string model, string color, int year, string _type, int _seat)
        {
            Name = _name;
            Model = model;
            Color = color;
            Year = year;
            Style = _type;
            Seat = _seat;
        }

        public override string PrintData()
        {
            return ("Name: " + Name + " Mode: " + Model + " Year: " + Year+ " Type: "+Style+" Seat: "+Seat);
        }
    }
}
