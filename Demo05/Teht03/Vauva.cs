using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Vauva:Ihminen
    {
        private string vaippa;

        public string Vaippa
        {
            get { return vaippa; }
            set { vaippa = value; }
        
        }
        public override string Liiku()
        {
            return ("Konttaa");
        }
        
            

        
    }
}
