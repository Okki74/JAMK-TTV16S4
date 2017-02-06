using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


/*Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia. TV-ohjelman tietoina tulee käsitellä: 
 * ohjelman nimi, kanava (jolta ohjelma tulee), alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta. 
 * Luo pääohjelmassa muutamia TV-ohjelmaolioita (tiedot voit alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä) ja tallenna ne levylle.
 *  Mieti käytätkö jotain tietorakennetta apunasi. Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville. */
namespace teht04
{
    
    class Program
    {
        static void Main(string[] args)
        {

            IFormatter formatter = new BinaryFormatter();
            List<TvProgram> TvPrograms = new List<TvProgram>();
            TvPrograms.Add ( new TvProgram("Avara Maailma",4,"18.00","19:00","Avannin säälittävät pedot"));
            TvPrograms.Add ( new TvProgram("Putous", 3, "20:00", "21:00", "Huonoa teko viihdettä"));
            TvPrograms.Add ( new TvProgram("Ducks vs Wild", 45, "01:00", "02:00", "Hakataan mustaa lätkää mailoilla"));
            TvPrograms.Add  (new TvProgram("UUTISET", 4, "18:00", "19:00", "Vaihtoehtoisen totuuuden uutiset"));

            
            Stream writeMultipleStream = new FileStream("TvPrograms.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            
            formatter.Serialize(writeMultipleStream, TvPrograms);
            
            writeMultipleStream.Close();
            // create stream for reading persons
            Stream openStream = new FileStream("TvPrograms.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            // create a list and read persons into it from disk
            List<TvProgram> readTvPrograms = (List<TvProgram>)formatter.Deserialize(openStream);
            // close stream
            openStream.Close();

            // proof
            foreach (TvProgram p in readTvPrograms)
            {
                Console.WriteLine("Name:  {0} Channel {1}\n Alkaa:{2} Loppuu: {3}\n Info: {4}", p.Name, p.Channel,p.BegingTime,p.EndTime,p.InfoText);
            }
            Console.ReadKey();
        }
    }
}
