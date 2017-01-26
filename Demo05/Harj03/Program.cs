using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*ee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki,
 *  tyyppi ja rengaskoko. Tee tämän jälkeen Kulkuneuvo-luokka
 * muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla
  ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn.
 * Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina esim.
 * taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen 
 * (kokoelmaluokat käsitellään tarkemmin seuraavissa demoissa). 
 * Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä)
 * renkaineen. Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.
 * 
 */
namespace Harj03
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle saab = new Vehicle ("Saappi","900",new Tyre ("Hankoon","Liukas","225R17"),4);
            Console.WriteLine(saab.ToString());
            Console.WriteLine();
            Vehicle mopo = new Vehicle("Solifer", "PV", new Tyre("Nokia", "Pitävä", "20R5"), 2);
            Console.WriteLine(mopo.ToString());
            Console.ReadKey();
           
        }
    }
}
