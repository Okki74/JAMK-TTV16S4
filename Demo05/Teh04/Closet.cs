using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04
{
    class Closet
    {
        private bool slidingdoors;

        public List<Shirt> Shirts { get; set; }
        public List<Shorts> Shortses { get; set; }
        public List<Trousers> Trouserses { get; set; }
  
    public bool SlidingDoors
    {
        get { return slidingdoors; }
        set { slidingdoors = value; }
    }
        // Konstraktori
        public Closet(bool _slidingDoors) {
            slidingdoors = _slidingDoors;
            Shirts = new List<Shirt>();
            Shortses = new List<Shorts>();
            Trouserses = new List<Trousers>();
        }

        // Methods
        public void AddShirt(Shirt _shirt, int _pcs)
        {
            for (int i=0; i<_pcs; i++)
            {
                Shirts.Add(_shirt);
            }
        }
        public void AddShorts(Shorts _shorts, int _pcs)
        {
            for (int i = 0; i < _pcs; i++)
            {
                Shortses.Add(_shorts);
            }
        }
        public void AddTrousers(Trousers _trousers, int _pcs)
        {
            for (int i = 0; i < _pcs; i++)
            {
                Trouserses.Add(_trousers);
            }
        }
        public override string ToString()
        {
            
            string str = "SlidinDoors: " + SlidingDoors + "\n";
            foreach (Shirt _shirts in Shirts)
            {
                str += "\n";
                str += _shirts.ToString();
            }
            foreach (Shorts _shorts in Shortses)
            {
                str += "\n";
                str += _shorts.ToString();
            }
            foreach (Trousers _trouserst in Trouserses)
            {
                str += "\n";
                str += _trouserst.ToString();
            }
            return str;
           
        }
    }
}
