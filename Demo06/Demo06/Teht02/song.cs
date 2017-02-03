using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Song
    {
        private string name;
        private string time;


        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        // constructor
        public Song (string _name, string _time)
        {
            Name = _name;
            Time = _time;
        }
        // methods
        public override string ToString()
        {
            return (" " + Name + " " + Time);
        }
    }
}
