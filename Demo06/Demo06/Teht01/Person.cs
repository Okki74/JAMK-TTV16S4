using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Person
    {
        private string sotu;
        private string firstName;
        private string lastName;
        private int age;
        private int weight;
        private int height;
        // properties
        public string Sotu {
            get { return sotu; }
            set { sotu=value;}
    }
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

            set { if (value >= 0){
                    age = value;
                  }
            }
                
            }
        public int Weight
        {
            get { return weight; }

            set{if (value >= 0){
                    weight = value;
                }
            }

        }
        public int Height
        {
            get { return height; }

            set{if (value >= 0){
                    height = value;
                }
            }

        }
        // constructor
        public Person (string _sotu, string _firstName,string _lastName,int _age,int _weight,int _height)
        {
            Sotu = _sotu;
            FirstName = _firstName;
            LastName = _lastName;
            Age = _age;
            Weight = _weight;
            Height = _height;

        }
        // methods
        public override string ToString()
        {
            return ("Sotu: "+sotu+" Etunimi: "+FirstName+" Sukunimi: "+LastName+" Ikä: "+Age+" Pituus: "+Height+" Paino: "+Weight);
        }
    }
    }
