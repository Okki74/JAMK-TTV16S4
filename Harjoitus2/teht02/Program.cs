using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta,
 *  jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100.
 *   Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion Vahvistin-luokasta.
 *    Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla. 
 *    Käytä Vahvistin-luokassa get- ja set-aksessoreita. get-aksessori palauttaa äänenvoimakkuuden
 *     ja set-aksessori rajaa äänenvoimakkuuden arvoa
 */
namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            bool leave = false;
            int num;
            Amplifier button = new Amplifier();
            button.Volume = 5;
            Console.WriteLine("Volume is now " + button.Volume);
            do
            {
                
                
                Console.WriteLine("Give new volume value between "+ button.MinVolume+" - " +button.MaxVolume); // Käytetään luokan arvoja
                line = Console.ReadLine();
                bool result = int.TryParse(line, out num);
                if (result == true)
                {
                    button.Volume = num;
                    if ( num!= button.Volume && button.Volume==button.MinVolume ) // käytetään luokan arvoja 
                    {
                        Console.WriteLine("Volume is too low ");
                        Console.WriteLine("Volume is now " + button.Volume);
                    }
                    else if (num != button.Volume && button.Volume == button.MaxVolume)
                    {
                        Console.WriteLine("Volume is too high " +num);
                        Console.WriteLine("Volume is now " + button.Volume);
                    }else
                    {
                        Console.WriteLine("Volume is now " + button.Volume);
                    }
                }
                else if (line == "o") { leave = true; Console.WriteLine("Power is Off"); }
            } while (leave != true);
            Console.ReadKey();
        }
    }
}
