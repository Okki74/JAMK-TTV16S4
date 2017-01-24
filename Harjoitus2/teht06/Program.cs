using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita:
 *  kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia,
 *  tabletteja, läppäreitä, ... jne. Pohdi UML-kaaviota käyttäen millaisia
 *   luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) esiintyy
 *    ja käytä apua perintää, jos tavaroille löytyy yhteisiä ominaisuuksia.
 *     Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. 
 *     Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita.
 */
namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Article tavara = new Article("Palkinto", "PalkintoNurkka Oy", 6);
            Book miina = new Book("Miina ja Manu", "Otava", 5, 10, "lastenkirja");
            Phone mokia = new Phone("Lumia 950", "Nokia", 4, true, "Win 8.0");
            DigitalSheet CD = new DigitalSheet("Iron Maiden", "TDK", 3, "CD-äänilevy", 1, true);
            DigitalSheet DVD = new DigitalSheet("Häjyt", "TDK", 3, "DVD-elokuva", 8, true);
            Console.WriteLine(tavara.PrintData());
            Console.WriteLine(miina.PrintData());
            Console.WriteLine(mokia.PrintData());
            Console.WriteLine(CD.PrintData());
            Console.WriteLine(DVD.PrintData());
            Console.ReadKey();
        }
    }
}
