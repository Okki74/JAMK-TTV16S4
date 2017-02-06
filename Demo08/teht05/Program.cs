using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tehtävä 5 - Laskutoimituksia ja yksikkötestaus home Kotitehtävä

Toteuta ArrayCalcs-niminen luokka ja sen sisälle seuraavat staattiset-metodit: Sum, Average, Min ja Max. Metodit ottavat parametriksi
double[]-taulukon ja laskevat nimensä mukaisen laskutoimintuksen taulukon alkioille ja palauttavat tuloksen kutsuvalle ohjelmalle.
Toteuta pääohjelma ja esimerkiksi seuraavaa dataa sisältävä taulukko: double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; Kutsu
pääohjelmasta ArrayCalcs-luokan staattisia laskutoimituksia tekeviä metodeja annetun taulukon arvoilla ja tulosta tulokset näyttölaitteelle.

Esimerkkitulostus:
    Sum = 25,60
    Ave = 3,66
    Min = -4,50
    Max = 12,00
ArrayCalcs-luokan metodien testaaminen
Toteuta solutioniin uusi yksikkötestaukseen liittyvä projekti ja testaa ArrayCalcs-luokan kaikki metodit.
Kuinka ArrayCalcs-luokan metodit toimivat, jos välität parametrina tyhjän double[]-taulukon: double[] array = { }; */
namespace teht05
{
   public class Program
    {
        static void Main(string[] args)
        {
            //double [] taulu ={ };
            double[] taulu = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; 
            double sum, ave,max, min;

            sum = ArrayCalcs.Sum(taulu);
            ave = ArrayCalcs.Average(taulu);
            max = ArrayCalcs.Max(taulu);
            min = ArrayCalcs.Min(taulu);
            Console.WriteLine("Sum = {0}\nAve = {1:F2}\nMax = {2}\nMin= {3}",sum,ave,max,min);
            Console.ReadKey();
        }   
    }
}
