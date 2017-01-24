using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Amplifier
    {
        public readonly int MaxVolume=100;
        public readonly int MinVolume = 0;
        private int volume { get; set; }


        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < MinVolume) {
                    volume = MinVolume;
                }
                else if (value > MaxVolume)
                {
                    volume = MaxVolume;
                }
                else volume = value;    
            }
        }
        
    }
}
