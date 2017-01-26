using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.
Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).
Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi).
Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella.
Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa
Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa".
Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String).
Lisää vauvalle ominaisuus vaippa (String). Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.*/
namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Ihminen akke = new Ihminen();
            akke.Nimi = "Akke";
            akke.Ika = 40;
            akke.Kasva();
            Aikuinen okki = new Aikuinen();
            okki.Nimi = "Mikko";
            okki.Ika = 42;
            okki.Kasva();
            okki.Auto = "BMW";
            Vauva emmi = new Vauva();
            emmi.Nimi = " Emmi Sofia";
            emmi.Ika = 0;
            emmi.Vaippa = "Bamppers";
            Console.WriteLine(akke.Nimi + " " + akke.Ika + " " + akke.Liiku());
            Console.WriteLine(okki.Nimi + " " + okki.Ika + " "+okki.Auto+" "+ okki.Liiku());
            Console.WriteLine(emmi.Nimi + " " + emmi.Ika + " " + emmi.Vaippa + " " + emmi.Liiku());
            Console.ReadKey();
        }
    }
}
