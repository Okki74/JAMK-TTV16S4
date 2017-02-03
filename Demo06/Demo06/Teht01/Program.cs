using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("090806A2015", "Emmi", "Hirvonen", 2, 11, 74));
            persons.Add(new Person("100808-197K", "Anu", "Lirvonen", 40, 68, 168));
            persons.Add(new Person("111208-196E", "Anni", "Laukkanen", 8, 38, 145));
            persons.Add(new Person("090846-1988", "Leena", "Mononen", 70, 68, 174));
            persons.Add(new Person("090808A171D", "Aapo", "Hirvonen", 10, 45, 151));
            persons.Add(new Person("090808A2006", "okki", "Okkinen", 45, 112, 193));

            // sorting persons by Age
            persons.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            foreach (Person somebody in persons)
            {
                Console.WriteLine(somebody.ToString());
            }
            //Find person by sotu

            string str = "090808A171D";
            Person found = persons.Find(x => x.Sotu == str);
            if(found != null)
            {
                Console.WriteLine("Henkilö löyty");
            }

            Console.ReadKey();
        }
    }
}
