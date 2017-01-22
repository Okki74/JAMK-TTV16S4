using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vehicle
    {// properties
        public string Name { get; set; }
        public int Tyres { get; set; }
        public int Speed { get; set; }
        // Methods
        public void PrintData()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Tyres);
            Console.WriteLine(Speed);
        }
    public override string ToString()
        {
           
            return ""+Name+""+Tyres+""+Speed;
        }
    }
}
