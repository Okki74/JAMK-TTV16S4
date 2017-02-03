using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Team 
    {
        private string teamName;
        private string homePlace;

        public List<Player>Players { get; set; }
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }
        public string HomePlace
        {
            get { return homePlace; }
            set { homePlace = value; }
        }
        // kontruktori
        public Team (string _teamName,string _homePlace)
        {
            TeamName = _teamName;
            HomePlace = _homePlace;
            Players = new List<Player>();
            HaePelajaat(TeamName);
        }
        // Metodit
        public void HaePelajaat(string joukkue)
        {
            AddPlayer(new Player("Olli", "Aitola", 25, 60));
            AddPlayer(new Player("Joona", "Erving", 22, 53));
            AddPlayer(new Player("Niklas", "Friman", 23, 20));
            AddPlayer(new Player("Jaakko", "Jokinen", 23, 16));
            AddPlayer(new Player("Mikko", "Kalteva", 32, 7));
            AddPlayer(new Player("Mikko", "Kuukka", 31, 91));
            AddPlayer(new Player("Kai", "Lehtinen", 26, 59));
            AddPlayer(new Player("Alex", "Lindroos", 21, 34));
            AddPlayer(new Player("Sami", "Niku", 20, 8));
            AddPlayer(new Player("Juha", "Uotila", 32, 11));
            AddPlayer(new Player("Urho", "Vaakanainen", 18, 13));
            AddPlayer(new Player("Juuso", "Vainio", 22, 5));
            AddPlayer(new Player("Nolan", "Yonkman", 35, 43));
            AddPlayer(new Player("Urho", "Olkinuora", 26, 45));
            AddPlayer(new Player("Markus", "Ruusu", 19, 97));

            foreach (Player playe in Players)
            { 
                Console.Write(playe.ToString());
            }
        }
        public void AddPlayer(Player _player)
        {
            Players.Add(_player);
        }
        public void RemovePlayer(string _name)
        {
           
            Players.RemoveAll(p => p.FirstName == _name);
           
        }
        public override string ToString()
        {
            string str;
            str = "Joukkue: " + TeamName + " " + HomePlace + "\n";
            foreach (Player playe in Players)
            {
                                              
                str+=(playe.ToString());
            }
            return ("-----------------------------------------------------------------------------\n "+str);
        }

    }
}
