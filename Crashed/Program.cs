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
            Opiskelija [] opiskelijat = new Opiskelija[5];
            //opiskelijat[1] = new Opiskelija();
            opiskelijat[1].SetStudent("Olli Opiskelija", "Matikka", "Ujakuja 5", 43, 1);
            opiskelijat[1].SetStudent("Outi Opiskelija", "Äikkä", "Lujakuja 5", 23, 2);
            opiskelijat[1].SetStudent("Mikko Matikka", "Yltti", "Kalakuja 5", 13, 3);
            opiskelijat[1].SetStudent("Anu Anuska", "Matikka", "Peräkuja 6", 25, 4);
            opiskelijat[1].SetStudent("Matti Meikäläinen", "Liikka", "Hyppykuja 5", 73, 5);
            //Student student1 = new Student(1234, "Aku", "Ankkalinna 1", "040-12345678");
            //students[0] = student1;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(opiskelijat[i]);

            }






        }
    }
}
