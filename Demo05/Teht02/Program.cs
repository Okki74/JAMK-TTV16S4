using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy. Tee pienimuotoinen toteutus, 
 * joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista.*/
namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge upo = new Fridge(9.5, new Vegetable("Joensuu", "Kurkku"), new Food("HK", "Sininen"), new Drink("olvi", "Sandels"), 12);
            Console.WriteLine(upo.ToString());
            Console.ReadKey();
        }
    }
}
