using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tehtävä 3
Tehtävänäsi on ohjelmoida television toiminta. Samoin kuin edellinen tehtävä: mitä ominaisuuksia
ja toimintoja tekisit Televisio-luokkaan?
UML
Suunnittele Televisio-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.

Ohjelmointi
Toteuta Televisio-luokan ohjelmointi sekä pääohjelma, jolla luot olion Televisio-luokasta.
Säädä luomaasi Televsio-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi,
jotta televisio-olion käyttäminen jää näkyville
 */

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv salora = new Tv(true, 20, 50, 1);
            salora.Print();
            Console.ReadKey();
            salora.Brightness = 30;
            salora.VolumeDown();
            salora.SetTextTv();
            salora.Print();
            Console.ReadKey();
            salora.SetTextTv();
            salora.BrightnessUp();
            salora.ChangeChannel(99);
            salora.Print();
            Console.ReadKey();
        }
    }
}
