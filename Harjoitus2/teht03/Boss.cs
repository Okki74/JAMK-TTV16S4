using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Boss:Employee
    {
        private string car; 
        private int bonus; 

        public string Car
        {
            get { return car; }
            set { car = value; }
        }
        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public override string PrintData()
        {
            return ("Name " + Name + " Profession: " + Profession + " Salary: " + Salary+ " Car: " +car+ " Bonus: "+bonus );
        }
    }
}
