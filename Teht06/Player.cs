using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Player
    {
        public int Number { get; set; }
        public int Goal { get; set; }
        public int Pass { get; set; }
        public String Team { get; set; }
        public String Place { get; set; }
        public String Name { get; set; }
        public  Player(int number, string name, string team, string place)
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
