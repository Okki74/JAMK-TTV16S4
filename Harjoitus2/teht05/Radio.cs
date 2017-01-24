using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Radio
    {
        private int volume;
        private double fregu;
        private bool onOff;
        private readonly int maxVolume=9;
        private readonly int minVolume = 0;
        private readonly double maxFregu = 26000.00;
        private readonly double minFregu=2000.00;


        public int MaxVolume
        {
            get { return maxVolume; }
        }
        public int MinVolume
        {
            get { return minVolume; }
        }
        public double MaxFregu
        {
            get { return maxFregu; }
        }
        public double MinFregu
        {
            get { return minFregu; }
        }
        public int Volume
        {
            get { return volume; }
            set{
                if (value >= minVolume && value <= maxVolume)
                {
                    volume = value;
                }
            }
        }
        public double Fregu{
            get { return fregu; }
            set{ 
                if (value>= minFregu && value <= maxFregu)
                {
                    fregu = value;
                }

            }
        }
        public bool OnOff 
        {
            get { return onOff; }
            set {
                if (onOff == false)
                {
                    onOff = true;
                }
                else onOff = false;
            }
        }
        public string PrintData()
        {
            return ("On: " + OnOff + " Volume: " + Volume + " Freguency: " + Fregu);
        }
    }
}
