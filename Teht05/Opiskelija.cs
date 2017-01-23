using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Opiskelija
    {

        private string Name;
        private int StudenNum;
        private string Course; 
        private string Address;
        private int Age;

        public void SetStudent(string name, string course, string address, int age, int studentNum)
        {
            Name = name;
            Course = course;
            Address = address;
            Age = age;
            StudenNum = studentNum;
        }
      
        public override string ToString()
        {
            return ("Name: " + Name + " Address: " + Address + " Age: " + Age + "\nStudent number: " + StudenNum + " Course: " + Course);

        }

    }

}

