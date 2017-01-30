using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Closet kuappi = new Closet(true);
            kuappi.AddShirt(new Shirt(true,"adidas","white",42,false), 4);
            kuappi.AddTrousers(new Trousers(false,"yellow", 12.0, true), 5);
            kuappi.AddShorts(new Shorts(true,"black",36.0,false),3);
            Console.WriteLine(kuappi.ToString());
            Console.ReadKey();
        }
    }
}
