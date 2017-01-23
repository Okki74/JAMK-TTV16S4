using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Opiskelija
    {
        
        public string Name { get; set; }
        public int StudenNum { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void SetStudent(string name,string course,string address,int age,int studentNum)
        {
            Name = name;
            Course = course;
            Address = address;
            Age = age;
            StudenNum = studentNum;
        }
        public override string ToString()
        {
            return ("Name: " + Name + " Address: " +Address+" Age: " +Age+"\n Student number: " + StudenNum + " Course: " + Course); 
              
        }

    }
       
    }

