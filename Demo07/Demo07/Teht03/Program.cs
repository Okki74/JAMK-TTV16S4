using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku)
 *  ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut. Sovellus tulee lopettaa,
 *   jos käyttäjä ei syötä kokonais- tai reaalilukua. Tarkista tiedostojen sisältö jollain tekstieditorilla.

Esimerkkitulostus:


    Give a number (enter or not a number ends) : 1,0
    Give a number (enter or not a number ends) : 2,0
    Give a number (enter or not a number ends) : 3,0
    Give a number (enter or not a number ends) : 4
    Give a number (enter or not a number ends) : 5
    Give a number (enter or not a number ends) : 6
    Give a number (enter or not a number ends) :
    
    Contents of T2Integers.txt:
    4
    5
    6

    Contents of T2Doubles.txt:
    1,0
    2,0
    3,0
    
 */
namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            string intPath = @"D:\temp\int.txt";
            string doublePath = @"D:\temp\double.txt";
            string input;
            int ints;
            double doubles;
            bool exit=false;
            StreamWriter intOutputFile = null;
            StreamWriter doubleOutputFile = null;
            try
            {
                intOutputFile = new StreamWriter(intPath);
                doubleOutputFile = new StreamWriter(doublePath);
                while (!exit)
                {
                
                    Console.WriteLine("Anna numero:");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out ints))
                    {
                        intOutputFile.WriteLine(ints);
                    }
                    else if (double.TryParse(input, out doubles))
                    {
                        doubleOutputFile.WriteLine(doubles);
                    }
                    else if (input == "")
                    {
                        exit = true;
                    }
                    else {Console.WriteLine( "Syötä numero"); }
                }
                intOutputFile.Close();
                doubleOutputFile.Close();
            
             if (File.Exists(intPath))
                {
                    Console.WriteLine("Contents of " + intPath);
                    string[] intLines = File.ReadAllLines(intPath);
                    foreach (string intLine in intLines)
                    {
                     Console.WriteLine(intLine);
                    }
                }
                if (File.Exists(doublePath))
                {
                    Console.WriteLine("Contents of " + doublePath);
                    string[] doubleLines = File.ReadAllLines(doublePath);
                    foreach (string doubleLine in doubleLines)
                    {
                        Console.WriteLine(doubleLine);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
