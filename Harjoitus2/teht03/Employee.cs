using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Employee
    {
        private string name; 
        private string profession; 
        private int salary;
        
       
        
        public string Name
        {
            get{return name;}
            set { name = value; }
        }
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        // Konstrutorit
        public Employee() { }
        public Employee(string _name, string _profession, int _salary)
        {
            name = _name;
            profession = _profession;
            salary = _salary;
        }
        // Methods
        public virtual string PrintData ()
        {
            return ("Name: " + name + " Profession: " + profession + " Salary: " + salary);
        } 
    }
}
