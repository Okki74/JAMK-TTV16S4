using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.
Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, äänen voimakkuuden
säädin (arvot 0, 1, 2,..., 9) ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0).
Laadi luokka kannettavan radion toteutukseksi. Käytä tekemääsi luokkaa pääohjelmasta käsin,
eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla. Jätä asetus-
ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.
 */
namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        { string line;
            int num;
            double num2;
            bool result;
            Radio asa = new Radio();
            asa.OnOff = true;
            asa.Fregu = asa.MinFregu;
            Console.WriteLine("Give new volume value between " + asa.MinVolume + " - " + asa.MaxVolume); // Käytetään luokan arvoja
            line = Console.ReadLine();
             result = int.TryParse(line, out num);
            if (result == true)
            {
                asa.Volume = num;
            }
            Console.WriteLine("Give new volume value between " + asa.MinFregu + " - " + asa.MaxFregu); // Käytetään luokan arvoja
            line = Console.ReadLine();
            result = double.TryParse(line, out num2);
            if (result == true)
            {
                asa.Fregu = num2;
            }
            Console.WriteLine(asa.PrintData());
            Console.ReadKey();
            asa.OnOff = true;
            asa.Fregu = asa.MinFregu;
            asa.Volume = asa.MinVolume;
            Console.WriteLine(asa.PrintData());
            Console.ReadKey();
        }
    }
}
