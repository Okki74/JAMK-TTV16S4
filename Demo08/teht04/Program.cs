using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Toteuta sovellus, jolla voidaan käsitellä erilaisia kuviota (esim. Circle ja Rectangle). Laadi erillinen abstrakti Shape-luokka, 
 * josta muut kuviot peryityvät. Määrittele Shape-luokan ominaisuutena kuvion nimi (Name) ja abstraktit Area- ja Circumference-metodit 
 * (pinta-ala ja ympärysmitta). Peri Circle- ja Rectangle-luokat Shape-luokasta ja toteuta Area- ja Circumference-metodit.
 *  Luo Shapes-luokka ja sen sisälle List-tietorakenne, jonne voit aina lisätä kuvioita. Toteuta pääohjelma, jossa käytät Shapes-luokkaa, 
 *  luo muutamia eri kuviota ja lisää ne Shapes-luokassa olevaan List-tietorakenteeseen. Käy pääohjelmassa lopuksi läpi Shapes-luokan 
 *  List-tietorakenne ja tulosta kaikki sen sisältämät kuviot.
 *  Circle Radius=1 Area=3,14 Circumference=7,28
    Circle Radius=2 Area=12,57 Circumference=12,56
    Circle Radius=3 Area=28,27 Circumference=18,84
    Rectangle Width=10 Height=20 Area=200,00 Circumference=60,00
    Rectangle Width=20 Height=30 Area=600,00 Circumference=100,00
    Rectangle Width=40 Height=50 Area=2000,00 Circumference=180,00

    Press enter key to continue... */
namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes drawings = new Shapes();
            drawings.AddCircle(1);
            drawings.AddCircle(2);
            drawings.AddCircle(3);
            drawings.AddRectangle(10, 20);
            drawings.AddRectangle(30, 20);
            drawings.AddRectangle(40, 50);
            Console.Write(drawings.ToString());
            Console.ReadKey();

        }
    }
}
