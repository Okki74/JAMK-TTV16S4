using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Luo Vehicle-luokka seuraavien tietojen mukaisesti:

ominaisuudet
Name:string
Speed:int
Tyres:int

toiminnot
PrintData(), tulostaa Vehiclen ominaisuudet näytölle
ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona

Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta.
Muuta olion arvoja ja tulosta olion arvoja konsolille.
 * 
 */
namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            car.Name = "Saab";
            car.Speed = 100;
            car.Tyres = 5;
            car.PrintData();
            Console.ReadKey();
            string str=car.ToString();
            Console.WriteLine(str);
            Console.ReadKey();
            car.Speed = 149;
            car.Name = "Skoda";
            car.Tyres = 4;
            str = car.ToString();
            Console.WriteLine(str);
            Console.ReadKey();


        }
    }
}
