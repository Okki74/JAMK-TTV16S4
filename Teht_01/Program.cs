using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas();
            harvia.KiuasOn();
            harvia.Moiseture = 60;
            harvia.Temperature = 70;
            Console.WriteLine(harvia.OnOff);
            Console.WriteLine(harvia.Moiseture);
            Console.WriteLine(harvia.Temperature);
            Console.ReadKey();
            // Lisätään lämpöä ja vähennetään kosteutta
            harvia.MoreHeat();
            harvia.LessSteam();
            Console.WriteLine();
            Console.WriteLine(harvia.OnOff);
            Console.WriteLine(harvia.Moiseture);
            Console.WriteLine(harvia.Temperature);
            Console.ReadKey();
            // vähennetään lämpöa ja lisätään kosteutta
            harvia.LessHeat();
            harvia.MoreSteam();
            Console.WriteLine();
            Console.WriteLine(harvia.OnOff);
            Console.WriteLine(harvia.Moiseture);
            Console.WriteLine(harvia.Temperature);
            Console.ReadKey();
            // Pois päältä
            harvia.KiuasOff();
            Console.WriteLine(harvia.OnOff);
            Console.ReadKey();
        }
    }
}
