using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Card
    {
        public string maa ;
        private string num;

        public string Maa
        {
            get { return maa; }
            set { maa = value; }
        }
        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        public Card (string _maa,string _num)
        {
            Maa = _maa;
            Num = _num;
        }
        //methods
        public override string ToString()
        {
            return  "" +Maa+" "+Num;
        }
    }
}
