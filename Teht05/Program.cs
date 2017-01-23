using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*   Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja.
 *   Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, joka luo muutamia opiskelijoita ja
 *   tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). Tulosta taulukossa olevien opiskelijoiden tiedot 
 *   käyttämällä toistorakennetta.
 */
namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Opiskelija[] opiskelijat = new Opiskelija[5];
            for (int j = 0; j <=4; j++)
            { 
                opiskelijat[j] = new Opiskelija();
            }
            opiskelijat[0].SetStudent("Olli Opiskelija", "Matikka", "Ujakuja 5", 43, 1);
            opiskelijat[1].SetStudent("Outi Opiskelija", "Äikkä", "Lujakuja 5", 23, 2);
            opiskelijat[2].SetStudent("Mikko Matikka", "Yltti", "Kalakuja 5", 13, 3);
            opiskelijat[3].SetStudent("Anu Anuska", "Matikka", "Peräkuja 6", 25, 4);
            opiskelijat[4].SetStudent("Matti Meikäläinen", "Liikka", "Hyppykuja 5", 73, 5);
           
            for (int i = 0; i <= 4; i++)
            {
                str = opiskelijat[i].ToString();
                Console.WriteLine(str);
                
            }
            Console.ReadKey();

        }
    }
}

