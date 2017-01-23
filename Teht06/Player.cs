using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Player
    {
        public int Number;
        public int Goal;
        public int Pass;
        public String Team;
        public String Place;
        public String Name;
        public void SetPlayer(int number, string name, string team, string place)
        {
            Number = number;
            Name = name;
            Team = team;
            Place = place;
        }
        public void OneGoal()
        {
            Goal += 1;

        }
        public void OnePass()
        {
            Pass += 1;
        }
        public override string ToString()
        {
            return (" " + Name + "    " + Number + "     " + Place + "    " + Team + "      " + Goal + "+" + Pass);

        }
    }
}
