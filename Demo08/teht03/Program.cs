using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tehtävä 3 - Kalat home Kotitehtävä
Toteuta sovellus, jossa voit hallita kalastukseen liittyviä tietoja.
Ohjelman pitää pystyä käsittelemään: saadun kalan perustiedot (laji, pituus ja paino), 
kalastajan perustiedot (nimi, puhelinnumero) sekä saadun kalapaikan perustiedot (nimi ja paikka). 
Pohdi tarvittava luokkarakenne UML-kaaviona. Toteuta pääohjelmassa kalastaja ja muutamia kaloja.
Tulosta lopuksi kalarekisterin sisältö.

Esimerkkitulostus:
    A new fisherman added to register:
     - Fisherman: Kirsi Kernel Phone: 020-12345678
    Fisher : Kirsi Kernel got a new fish
     - specie : pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä
    Fisher : Kirsi Kernel got a new fish
     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland
    All fishes in register:
    Fisherman Kirsi Kernel has got following fishes:
     - specie: pike 120 cm 4,5 kg
     - place: The Lake of Jyväskylä
     - location: Jyväskylä
     - specie: salmon 190 cm 13,2 kg
     - place: River Teno
     - location: The Northern edge of Finland*/
namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            fisher fisherman = new fisher("Kaija Kalastaja","044599866");
            str=fisherman.AddFish(new fish(1.2, 54, "salmon", "Joensuu", "Pyhäselkä"));
            Console.WriteLine(str);
            str=fisherman.AddFish(new fish(0.5, 45, "Alamitta", "Lieksa", "Pielinen"));
            Console.WriteLine(str);
            str =fisherman.AddFish(new fish(1.2, 58, "pike", "Joensuu", "Pyhäselkä"));
            Console.WriteLine(str);
            Console.ReadKey();
            str = fisherman.PrintData();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
