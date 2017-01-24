using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin.
 *  Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja 
 *  siirtämään hissi haluttuun kerrokseen (tässä tapauksessa ohjelma kertoo käyttäjälle
 *   missä kerroksessa hissi on). Muista, että Dynamon hissi voi olla vain kerroksissa 1-5.
 *   Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila. 
 */
namespace tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            bool leave = false;
            int luku;
            Elevator hissi = new Elevator();
            hissi.Floor = 1;
               do {
                Console.WriteLine("Elevator is floor: " + hissi.Floor);
                Console.WriteLine("Give a new floor number between 1-5: ");
                line = Console.ReadLine();
                bool result = int.TryParse(line, out luku);
                if (result == true)
                {
                    if (luku == 0){ leave = true; Console.WriteLine("Door is open"); break; }
                    hissi.Floor = luku;
                } else
                {
                    Console.WriteLine("Give a new floor number between 1-5: ");
                }
            } while (leave != true) ;
            Console.Read();


        }
    }
}
