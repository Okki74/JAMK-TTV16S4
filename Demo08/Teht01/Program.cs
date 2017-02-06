using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla. 
 * Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. Toteuta tämän jälkeen ohjelma siten, 
 * että kysyt käyttäjältä heittojen määrän. Heitä noppaa ja tulosta heittojen lukujen keskiarvo.

Esimerkkitulostus:


    Dice, one test throw value is 4
    


    How many times you want to throw a dice :  10000
    Dice is now thrown 10000 times, average is 3,4853
    

+tehtävä. Tulosta lopuksi kaikkien heitettyjen lukujen esiintymismäärät.


    How many times you want to throw a dice :  10000

    Dice is now thrown 10000 times
    - average is 3,4853
    - 1 count is 1726
    - 2 count is 1610
    - 3 count is 1705
    - 4 count is 1691
    - 5 count is 1580
    - 6 count is 1688

    Press enter key to continue...
    
 */
namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int trowtimes;
            int tulos;
            Dice noppa = new Dice();
            Resluts tulokset = new Resluts();
            tulos = noppa.trowDice();
            Console.WriteLine("Test trow: "+tulos);
            Console.WriteLine("how many times you want to trow a dice: ");
            string txt = Console.ReadLine();
             if (int.TryParse(txt,out trowtimes)){
                tulokset.TrowTimes = trowtimes;
                for (int i = 0; i < trowtimes; i++)
                {
                    tulos = noppa.trowDice();
                    tulokset.ResultSaver(tulos);
                }       
            }
            Console.WriteLine("How many times you want to throw a dice :" + tulokset.TrowTimes);
            Console.WriteLine("average is {0:N2}",((double)tulokset.Sum/tulokset.TrowTimes));
            Console.Write(tulokset.ToString());
            Console.ReadKey();
        }
    }
}
