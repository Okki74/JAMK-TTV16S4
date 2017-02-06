using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Toteuta ohjelma, jolla voidaan lisätä, poistaa ja listata SM-Liiga-joukkueen JYP pelaajia. Luo Pelaaja-luokka jolla on ominaisuudet
 *  Etunimi, Sukunimi, Ikä ja Numero. Löydät täältä JYP pelaajat kaudella 2016-17. Luo myös Joukkue-luokka. Luokalla on ominnaisuudet 
 *  Nimi, Kotikaupunki ja Pelaajat. Ominaisuus Pelaajat on siis lista Pelaaja-olioita. Tee Joukkue-luokalle sisäinen metodi HaePelaajat
 *  (string joukkue), jota konstruktori kutsuu. HaePelaajat metodi luo Pelaajat-listaan oikeat pelaajat.
Bonustehtävä: missä ja miten pitäisi pelaajatietoja silloin tallessa kun ohjelma ei ole käynnissä? Listaa erilaiset vaihtoehdot.
Toteuta niistä tekstitiedosto-pohjainen ratkaisu.*/
namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Team jyp = new Team("JYP", "Jyväskylä");
            Console.ReadKey();
            jyp.AddPlayer(new Player("Valtteri", "Hotakainen", 26, 21));
            jyp.AddPlayer(new Player("J-P", "Hytönen", 35, 15));
            jyp.AddPlayer(new Player("Henri", "Kanninen", 22, 71));
            jyp.AddPlayer(new Player("Janne", "Kolehmainen", 30, 55));
            jyp.AddPlayer(new Player("Arttu", "Likola", 22, 41));
            jyp.AddPlayer(new Player("Ossi", "Luohivaara", 33, 23));
            jyp.AddPlayer(new Player("Anssi", "Löfman", 29, 21));
            jyp.AddPlayer(new Player("Veini", "Vehvilainen", 19, 1));
            Console.Write(jyp.ToString());
            Console.ReadKey();
            jyp.RemovePlayer("Veini", "Vehvilainen");
            Console.Write(jyp.ToString());
            Console.ReadKey();
        }
    }
}
