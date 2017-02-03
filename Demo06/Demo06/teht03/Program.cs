using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck pakka = new Deck();
            Console.WriteLine(pakka.ToString());
            Console.ReadKey();
            pakka.Sekotus();
            Console.WriteLine(pakka.ToString());
            Console.ReadKey();
        }
    }
}
