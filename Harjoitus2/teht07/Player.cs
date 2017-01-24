using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää.
 */
namespace teht07
{
    class Player:Person
    {
        private int playerNum;
        private int goals;
        private int pass;
        private int score;

    public int PlayerNum
        {
            get { return playerNum; }
            set { playerNum = value; }
             
        }
        public int Goals
        {
            get { return goals; }
            set { goals = value; }

        }
        public int Pass
        {
            get { return pass; }
            set { pass = value; }

        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        // Konstruktori
        public Player() { }
        public Player(string name, int age, int phone, string roles, int _playernum, int _goals, int _pass)
    {
        Name = name;
        Age = age;
        Phone = phone;
        Roles = roles;
        playerNum = _playernum;
        goals = _goals;
        pass = _pass;
        score = goals + pass;

    }
        // methods
        public override string DataPrint()
        {
            return ("Nimi: " + Name + " Ikä; " + Age + " Puh: " + Phone + " Rooli;" + Roles+ " \n Numero: "+PlayerNum+"Pisteet: "+Goals+"+"+Pass+"="+Score);

        }
    }
}
