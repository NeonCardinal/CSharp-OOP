using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public  class Person
    {
        private int age;
        private string name;

        public int Age
        { 
            get { return age; } 
            set 
            {
                if(value < 0)
                    value = 0;
                age = value; 
            } 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
