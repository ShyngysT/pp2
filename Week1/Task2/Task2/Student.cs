using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Student
    {
       private string name;
       private  string id;
       public int yearofstudy;


       public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
         

        }

        public string getName()
        {
            return this.name;
        }

        public string getid()
        {
            return this.id;
        }

        public int getyearofstudy()
        {
            return this.yearofstudy;
        }

    }
}
