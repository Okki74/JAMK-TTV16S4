using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. Ostettavalta tuotteelta riittää käsitellä nimi ja hinta.
 *  Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi List-tietorakenteeseen muutamia Product-luokan oliota.
 *   Tulosta lopuksi kokoelman sisältö.

Esimerkkitulostus:


    All products in collection:
    - product : Milk 1,4 e
    - product : Beer 2,2 e
    - product : Butter 3,2 e
    - product : Cheese 4,2 e
    
    Press enter key to continue...
    */
namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            List<product> products = new List<product>();
            products.Add(new product("Beer",0.99));
            products.Add(new product("Milk", 0.64));
            products.Add(new product("Tomato", 1.99));
            products.Add(new product("Bred", 1.34));
            products.Add(new product("Candy", 4.99));
            foreach (product staff in products)
            {
                total = total+ staff.Price;
                Console.WriteLine(staff.ToString());
            }
            Console.WriteLine("     total price: " + total+" euro");
            Console.ReadKey();
        }
    }
}
