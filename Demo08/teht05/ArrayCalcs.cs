using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    public class ArrayCalcs
    {
        
        public static double Sum(double [] taulu)
        {
            double sum=0;
            foreach (double s in taulu)
            {
                sum += s;
                
            }
            return sum;
        }
        public static double Average(double [] taulu)
        {
            double sum = 0;
            
            foreach (double s in taulu)
            {
                sum += s;
               
            }
            double ave = sum / taulu.Length;
            return ave;
        }
        public static double Max(double [] taulu)
        {
            double max = 0;
            foreach (double s in taulu)
            {
                if (s > max)
                {
                    max = s;
                }
            }
            return max;
        }
        public static double Min(double [] taulu)
        {
            double min = 0;
            for (int i=0;i< taulu.Length;i++)
            {   
                if (i == 0)
                {
                    min = taulu[i];
                }
                else if (taulu[i] < min)
                {
                    min = taulu[i];
                }
            }
            return min;
        }

    }
    
}

