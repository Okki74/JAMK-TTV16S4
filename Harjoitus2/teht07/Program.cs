using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jojo = new Person("Jouko Johtaja", 45, 0505998642, "Joukkueen johtaja");
            Console.WriteLine(jojo.DataPrint());
            Player kp = new Player("Kalle Kenttäpelaaja", 23, 0507787317, "Hyökkääjä", 27, 12, 23);
            Console.WriteLine(kp.DataPrint());
            Goalkeeper mv = new Goalkeeper("Make Molari", 28, 050884567, "Maalivahti", 1, 0, 1, 100.00, 92.00);
            Console.WriteLine(mv.DataPrint());


            Console.ReadKey();
        }
    }
}
