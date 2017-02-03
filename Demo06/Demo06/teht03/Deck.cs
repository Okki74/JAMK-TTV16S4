using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Deck
    {
        public List<Card> Cards { get; set; }
        private Random rando;

        public Deck()
        {
            string[] cardsNum = new string[13] { "ässä", "kaks1", "kolme", "nelkku", "viisi", "kuusi", "Seiska", "kasi", "ysi", "Kymppi", "Jätkä", "Akka", "Kunkku" };
            string[] land = new string[4] { "Hertta", "Ruutu", "Pata", "Risti" };
            rando = new Random();
            Cards = new List<Card>();
            for (int q = 1; q < 53; q++)
            {
                if (q <= 13)
                {
                    Cards.Add(new Card(land[0], cardsNum[q - 1]));
                }
                else if (q > 12 && q <= 26)
                {
                    Cards.Add(new Card(land[1], cardsNum[q - 14]));
                }
                else if (q > 26 && q <= 39)
                {
                    Cards.Add(new Card(land[2], cardsNum[q - 27]));
                }
                else if (q > 39)
                {
                    Cards.Add(new Card(land[3], cardsNum[q - 40]));
                }
            }
        }
        public void Sekotus()
        {
            Random rando = new Random();
            for (int i=0; i< Cards.Count; i++)
            {
                int j = rando.Next(Cards.Count);
                Card temp = Cards[i];
                Cards[i]= Cards[j];
                Cards[j]=temp;



            }

        }

        public override string ToString()
        {
            string str = " Korttit: \n";
            int i = 0;
            int j = 1;
            foreach (Card t in Cards)
            {
                str += " " +j  ;
                if (i >= 4) { str += "  \n"; i = 0; }
                else  { str += " "; }
                str += t.ToString();
                i++;
                j++;
            }
            return str;
        }
    }
}
