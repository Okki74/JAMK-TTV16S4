using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Person
    {   // Jäsenmuuttujat
        private string name;
        private string roles;
        private int age;
        private int phone;
        
        // properties
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Roles{
            get { return roles; }
            set { roles = value; }
        }
        public int Age{
            get { return age ; }
            set { age = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        // Kontruktorit
        public Person() { }
        public Person(string _name, int _age,int _phone, string _roles)
        {
            name = _name;
            age = _age;
            phone = _phone;
            roles = _roles;
        }

        // methods
        public virtual string DataPrint()
        {
            return ("Nimi: " + Name + " Ikä; " + Age +" Puh: "+Phone+ " Rooli;" + Roles);
            
        }  

    }
}
