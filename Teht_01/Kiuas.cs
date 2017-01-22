using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tehtävänäsi on ohjelmoida kiukaan toiminta.
 *  Kiuas pitää pystyä laittamaan päälle ja pois, sekä sen lämpötilaa että sen antamaa kosteutta
 *   pitää pystyä säätämään (arvoja ei ole rajattu).
UML
Suunnittele Kiuas-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.
Ohjelmointi
Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion Kiuas-luokasta.
Säädä kiuas-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi,
jotta kiuas-olion käyttäminen jää näkyville.
 */
namespace Teht_01
{
    class Kiuas
    {
        //properties
        public Boolean OnOff { get; set; }
        public int Temperature { get; set; }
        public  int Moiseture { get; set; }
        // method
        
        public void KiuasOn()
        {
            OnOff = true;
        }
        public void KiuasOff()
        {
            OnOff = false;
        }
        public void MoreHeat()
        {
            Temperature += 5;
        }
        public void LessHeat()
        {
            Temperature -= 5;
        }
        public void MoreSteam()
        {
            Moiseture += 3;
        }
        public void LessSteam()
        {
            Moiseture -= 3;
        }
    }
}
