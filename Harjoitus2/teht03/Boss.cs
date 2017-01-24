using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Boss:Employee
    {
        private string car; //{ get; set; }
    private int bonus; //{ get; set; }

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
