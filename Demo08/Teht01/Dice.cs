using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Dice
    {
        private int result;
        Random numberGenerator = new Random();

        public int Result
        {
            get { return result; }    
        }
    

        public int trowDice ()
        {
            result = numberGenerator.Next(1, 7); 
            return Result;
        }

    }
}
