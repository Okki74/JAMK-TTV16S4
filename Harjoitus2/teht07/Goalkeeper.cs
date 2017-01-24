using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Goalkeeper : Player
    {
        private double shoots;
        private double saves;
        private double savesPros;
        // Properties
        public double Saves {
            get { return saves; }
            set { saves = value; }
        }
        public double Shoots
        {
            get { return shoots; }
            set { shoots = value; }
        }
        // Konstruktori
        public Goalkeeper(string name, int age, int phone, string roles, int playernum, int goals, int pass, double _shoots,double _saves)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Roles = roles;
            PlayerNum = playernum;
            Goals = goals;
            Pass = pass;
            Score = goals + pass;
            shoots = _shoots;
            saves = _saves;
            savesPros =  (saves / shoots)* 100.00;

        }
        // methods
        public override string DataPrint()
        {
            return ("Nimi: " + Name + " Ikä; " + Age + " Puh: " + Phone + " Rooli;" + Roles + " \nNumero: " + PlayerNum + "Pisteet: " + Goals + "+" + Pass + "=" + Score+"\nLaukaukset: "+Shoots+" Torjunnat: "+Saves+" Torjuntaprosentti: "+savesPros+"%");

        }
    }
}
