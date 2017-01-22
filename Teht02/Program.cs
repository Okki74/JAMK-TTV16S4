using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tehtävänäsi on ohjelmoida pesukoneen toiminta. Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja
 *  toimintoja tekisit Pesukone-luokkaan?
UML
Suunnittele Pesukone-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.

Ohjelmointi

Toteuta Pesukone-luokan ohjelmointi sekä pääohjelma,
jolla luot olion Pesukone-luokasta. Säädä pesukone-oliota erilaisilla
arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta pesukone-olion
käyttäminen jää näkyville. Toteuta Pesukone-luokkaan muutamia erilaisia konstruktoreita
ja alusta niitä käyttämällä oliota pääohjelmasta käsin.
 */
namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            //WasingMa chinese = new WasingMa();
            
            WasingMa upo = new WasingMa(40, 1200, 60);
            upo.OnOff = true;
            WasingMa hoover = new WasingMa(2, 800);
            hoover.SetTemp(35);
            hoover.StarProgram();
            WasingMa aeg = new WasingMa(55, 1500, 9, true);
            Console.WriteLine("Upo");
            upo.Print();
            Console.WriteLine("Hoover");
            hoover.Print();
            Console.WriteLine("AEG");
            aeg.Print();
            Console.ReadKey();
            aeg.StopProgram();
            aeg.Print();
            Console.ReadKey();





        }
    }
}
