using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Player[] players = new Player[19];
            /*for (int j = 0; j <= 18; j++)
            {
                players[j] = new Player();
            }*/
            players[0]= new Player(1, "Make Molari", "Jokipojat", "Maalivahti");
            players[1] = new Player(64, "Marko Maali", "Jokipojat", "Hyökkääjä");
            players[2] = new Player(65, "Marko Maalari", "Jokipojat", "Hyökkääjä");
            players[3] = new Player(3, "Pekka Pakki", "Jokipojat", "Puolustaja");
            players[4] = new Player(33, "Tauno Taklaaja", "Jokipojat", "Puolustaja");
            players[5] = new Player(4, "Kari Koukku", "Jokipojat", "Puolustaja");
            players[6] = new Player(44, "Pentti Puolustaja", "Jokipojat", "Puolustaja");
            players[7] = new Player(15, "Heikki Hyökkääjä", "Jokipojat", "Hyökkääjä");
            players[8] = new Player(55, "Marko Maalaja", "Jokipojat", "Hyökkääjä");
            players[9] = new Player(1, "Seppo Syöttäjä", "Jokipojat", "Hyökkääjä");
            players[10] = new Player(13, "Pertti Pitkä", "Jokipojat", "Puolustaja");
            players[11] = new Player(19, "Ilkka Imuri", "Jokipojat", "Maalivahti");
            players[12] = new Player(12, "Pertti Pitkä", "Jokipojat", "Puolustaja");
            players[13] = new Player(93, "Harri Harhautus", "Jokipojat", "Hyökkääjä");
            players[14] = new Player(83, "Harri Harhautus1", "Jokipojat", "Hyökkääjä");
            players[15] = new Player(74, "Harri Harhautus2", "Jokipojat", "Hyökkääjä");
            players[16] = new Player(65, "Kari Kikka2", "Jokipojat", "Hyökkääjä");
            players[17] = new Player(69, "Pekka Poikkari", "Jokipojat", "Hyökkääjä");
            players[18] = new Player(43, "Reino Ranne", "Jokipojat", "Hyökkääjä");

            players[16].Goal = 12;
            players[16].Pass = 11;

            Console.WriteLine("Nimi             Pelipaikka              Seura         M  S");
           

            for (int i = 0; i <= 18; i++)
            {
                if (players[i].Place == "Maalivahti") {
                    str = players[i].ToString();
                    Console.WriteLine(str);
                }
            }
            Console.ReadKey();
            for (int i = 0; i <= 18; i++)
            {
                if (players[i].Place == "Puolustaja")
                {
                    players[i].OnePass();
                    str = players[i].ToString();
                    Console.WriteLine(str);
                }
            }
            Console.ReadKey();
            for (int i = 0; i <= 18; i++)
            {
                if (players[i].Place == "Hyökkääjä")
                {
                    players[i].OnePass();
                    players[i].OneGoal();
                    str = players[i].ToString();
                    Console.WriteLine(str);
                }
            }
         


            Console.ReadKey();

        }
    }
}