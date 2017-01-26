using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Aikuinen:Ihminen
    {
        private string auto;

        public string Auto
        {
            get { return auto; }
            set { auto = value; }
        }
        public override string Liiku()
        {
            return ("Juoksee");
        }
    }
}
