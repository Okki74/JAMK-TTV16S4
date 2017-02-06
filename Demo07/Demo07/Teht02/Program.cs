using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Tee ohjelma, joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä
 *  ja kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy. Kopioi (tai luo
 *   itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi tarkistamaan onko em.
 *   hakemistossa tiedostoa.Käytä File.Exist-metodia.	Huomioi myös muut mahdolliset poikkeukset
 *   joita tiedoston käsittely voi aiheuttaa.

Esimerkkitulostus:
    Löytyi 20 riviä, ja 9 nimeä.
	Nimi Aappo esiintyy 4 kertaa
	Nimi Benkku esiintyy 2 kertaa
	Nimi Jaakko esiintyy 3 kertaa
	Nimi Wille esiintyy 4 kertaa
	Nimi Sebastian esiintyy 1 kertaa
	Nimi Cecilia esiintyy 2 kertaa
	Nimi Netta esiintyy 2 kertaa
	Nimi Matias esiintyy 1 kertaa
	Nimi Otto esiintyy 1 kertaa
	Press any key to continue . .*/
namespace Teht02
{
    class Program
    {
        static void Main(string[] args)     
        {
            string path = @"D:\temp\nimet.txt";
            if (File.Exists(path))
            {
                
                try
                {
                    
                 
                    Dictionary<string, int> nimet = new Dictionary<string, int>();
                    string[] lines = System.IO.File.ReadAllLines(@"D:\temp\nimet.txt");
                    foreach (string line in lines)
                    {
                        if (!nimet.ContainsKey(line))
                        {
                              nimet.Add(line, 1);
                        } else
                        {
                            nimet[line]++;
                        }
                       
                        
                    }
                    Console.WriteLine ("Löytyi {0} riviä, ja {1} nimeä.", lines.Count(), nimet.Count);
                    
                    foreach (string nimi in nimet.Keys) {
                        Console.WriteLine("Nimi: " + nimi + " Löytyi: " + nimet[nimi] + " kertaa");
                    }
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
          
        }
    }
}
