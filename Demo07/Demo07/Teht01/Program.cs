using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto.
 *  Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. Huomioi mahdolliset poikkeukset,
 *   joita tiedoston käsittely voi aiheuttaa.

Esimerkkitulostus:


    Give a text line (enter ends) : Matti
    Give a text line (enter ends) : Teppo
    Give a text line (enter ends) : Seppo
    Give a text line (enter ends) : Jorma
    Give a text line (enter ends) :
    
    Contents of T1TextLines.txt:
    Matti
    Teppo
    Seppo
    Jorma
    */

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = null;
            List<string> text = new List<string>();
            int i = 0;
            string line;
            string inputti="";
            while (i < 5)
                {
                    Console.WriteLine(" Give a text:");
                    line = Console.ReadLine();
                    line += "\n";    
                    text.Add(line);
                    i++;
                
                }
             
                foreach (string data in text)
            {
                inputti += data; 
            }
            try
            {
                outputFile = new System.IO.StreamWriter("T1TextLines.txt");
                outputFile.WriteLine(inputti);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
            try
            {
                string outputti = System.IO.File.ReadAllText("T1TextLines.txt");
                System.Console.WriteLine(outputti);
            }catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }



        }
    }

