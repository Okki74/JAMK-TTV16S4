using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Aikaisemmissa demoissa tehtiin CD-luokka, joka sisälsi CD:lle yleisesti kuuluvia ominaisuuksia.
 *  Muuta/tee toteutus, jossa CD:n sisällä olevien biisien määrää ei ole rajattu. Käsittele CD:n 
 *  osalta ainakin seuraavat tiedot: nimi, artisti ja biisit.
Ohjelmoi suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olio.
Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä. Tulosta ruudulle CD:n tietoja. */
namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD lp = new CD("Tarjan lähtö", "yöwissy");
            lp.AddSong(new Song("Bye bye beautiful1","1:00"));
            lp.AddSong(new Song("Bye bye beautiful2", "2:00"));
            lp.AddSong(new Song("Bye bye beautiful3", "3:00"));
            lp.AddSong(new Song("Bye bye beautiful4", "4:00"));
            lp.AddSong(new Song("Bye bye beautiful5", "5:00"));
            lp.AddSong(new Song("Bye bye beautiful6", "6:00"));
            lp.AddSong(new Song("Bye bye beautiful7", "7:00"));
            CD lp2 = new CD("Kakkonen on ykkönen", "Popeda");
            lp2.AddSong(new Song("Biisi pitkä", "1:00"));
            lp2.AddSong(new Song("Pitempi", "2:00"));
            lp2.AddSong(new Song("Sukis luistava", "3:00"));
            lp2.AddSong(new Song("porkat", "4:00"));
            lp2.AddSong(new Song("Sorkat", "5:00"));
            lp2.AddSong(new Song("Kersantti", "6:00"));
            lp2.AddSong(new Song("Kylmä kesä", "7:00"));
            Console.WriteLine(lp.ToString());
            Console.WriteLine(lp2.ToString());
            Console.ReadKey();

        }
    }
}
