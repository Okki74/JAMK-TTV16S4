using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class fish
    {
        private double weight;
        private int height;
        private string specie;
        private string location;
        private string place;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public string Specie
        {
            get { return specie; }
            set { specie = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
            public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public fish (double _weigth, int _height, string _specie,string _location,string _place)
        {
            Weight = _weigth;
            Height = _height;
            Specie = _specie;
            Location = _location;
            Place = _place;
        }
        public override string ToString()
        {
            return ("Species: " + Specie + " " + Height + " cm " + Weight + " kg\nLocation: " + Location + " Place: " + Place+"\n");
        }
    }
}
