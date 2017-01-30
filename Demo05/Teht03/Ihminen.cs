using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Ihminen:Nisakas
    {
        private int paino;
        private int pituus;
        private string nimi;
  

        public int Paino
        {
            get { return paino; }
            set { paino = value; }
        } 
        public int Pituus
        {
            get { return pituus; }
            set { pituus = value; }
        }
        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }
       
        // Methods
        public override string Liiku()
        {
            return ("Liikun");
        }
        public void Kasva()
        {
            Ika += 1;
        }

    }
}
