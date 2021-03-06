﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Toteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja.
 *  Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: nimi, malli
 *  , vuosimalli ja väri. Erikoistapauksina pitää pystyä käsittelemään polkupyöriä
 *  ja veneitä. Polkupyörän osalta pitää pystyä erottelemaan se, että onko kyseessä
 *  vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi. Veneiden osalta tietoina
 *  pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka
 *  monta istuinpaikkaa veneestä löytyy.

Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot.
Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. Tietoja ei 
tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.
 */
namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("BMW", "520", "Black", 2010);
            Console.WriteLine(car.PrintData());
            Boat bella = new Boat("Bella 1", "M1", "White", 2000, "Moottori vene", 4);
            Console.WriteLine(bella.PrintData());
            Bicycle nopsa = new Bicycle("Nopsa","Kaunotar", "Red", 1980, "Simatic", true);
            Console.WriteLine(nopsa.PrintData());

            Console.ReadKey();
        }
    }
}
