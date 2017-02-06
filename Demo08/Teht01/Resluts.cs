using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Resluts
    {
        private int ones;
        private int twos;
        private int trees;
        private int fours;
        private int fifes;
        private int sixes;
        private int sum;
        private int trowTimes;
       
       

        public int Ones{get { return ones; } set { ones = value; }}
        public int Twos{get { return twos; }set { twos = value; }}
        public int Trees { get { return trees; }set {trees = value; }}
        public int Fours { get { return fours; }set { fours = value; }}
        public int Fifes{get { return fifes; }set { fifes = value; }}
        public int Sixes{get { return sixes; }set { sixes = value; } }
        public int Sum { get { return sum; } set { sum = value; } }
        public int TrowTimes { get { return trowTimes; } set { trowTimes = value; } }


        public void ResultSaver(int _tulos)
        {
           
            Sum = Sum + _tulos;
            switch (_tulos)
            {
                case 1: Ones++; break;
                case 2: Twos++; break;
                case 3: Trees++; break;
                case 4: Fours++; break;
                case 5: Fifes++; break;
                case 6: Sixes++; break;
                default: break;
            }
        }
      
            public override string ToString()
             {
            
            return ("\n1 count" + Ones + "\n2 count" + Twos + "\n3 count" + Trees + "\n4 count" + Fours + "\n5 count" + Fifes + "\n6 count" + Sixes);
          
        }

    }
 }
  
