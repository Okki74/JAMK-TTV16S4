using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). 
Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: työntekijän nimi (Name), 
työntekijän ammatti (Profession) ja palkka (Salary). Samassa ohjelmassa pitää pystyä käsittelemään
myös johtajien tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).
Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot.
Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. Tietoja ei tarvitse
kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.
Esimerkkitoiminta: (huomaa, että Kirsi Kernelin tietoja on muutettu ohjelman suorituksessa)
 */
namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boss nilkki = new Boss();
            Employee lusmu = new Employee(); //oletus konstrutori
            Employee tekija = new Employee("Kari Uoti", "Söhlä", 2500);// määritelty konsturktori
            nilkki.Name = "Pekka Puska";
            nilkki.Profession = "Ingen jööräre";
            nilkki.Car = "Saab";
            nilkki.Salary = 5500;
            nilkki.Bonus = 4000;
            lusmu.Name = " Timo Soini";
            lusmu.Profession = "Paskan Jauhaja";
            lusmu.Salary = 200;
            Console.WriteLine(lusmu.PrintData());
            Console.WriteLine(tekija.PrintData());
            Console.WriteLine(nilkki.PrintData());
            lusmu.Salary = 500;
            Console.WriteLine(lusmu.PrintData());
            Console.ReadKey();

        }
    }
}
