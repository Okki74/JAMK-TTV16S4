using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj03
{
    class Vehicle
    {
        public List<Tyre> Tyres { get; set; }       
        private string name;
        private string model;
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public Vehicle() { }
        public Vehicle(string _name, string _model, Tyre _tyres, int _kplTyres)
        {
            Tyres = new List<Tyre>();
            Name = _name;
            Model=_model;
            for (int j = 0; j < _kplTyres; j++)
            {
               AddTyres(_tyres);
            }

        }
       
        // Methods
        public void RemoveTyre()
        {
            
            Tyres.Clear();
        }
        public void AddTyres (Tyre t)
        {
            
            Tyres.Add(t);
        }
       
        public override string ToString()
        {
            string str = "Vehicle: " + Name + " " + Model+ "\n";
            foreach (Tyre t in Tyres)
            {
                str += "\n";
                str += t.ToString();
            }
            return str;
        } 
    }
}
