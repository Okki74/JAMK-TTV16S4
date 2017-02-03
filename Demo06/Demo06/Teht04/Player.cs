using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Player 
    {
        private string firstName;
        private string lastName;
        private int age;
        private int number;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public Player() { }
       public Player (string _firstName, string _lastName, int _age, int _number)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Age = _age;
            Number = _number;
        }

        public override string ToString()
        {
            return (" Etunimi: " + FirstName + " Sukunimi: " + LastName + " Pelinumero:" + Number + " Ikä: " + Age + "\n");
        }

    }
}
