using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä1
{
    class Elevator
    {
        private readonly int MaxFloor = 5;
        private readonly int MinFloor = 1;
        private int floor { get; set; }

        public int  Floor
        {
            get{
                return floor;
            }
            set
                { 
                if ( value >=MinFloor && value <= MaxFloor) { floor = value; }
                else {
                    Console.WriteLine("Floors is between 1-5. Your give floor " +value);
                    }

            }
        }
            
    }
}
