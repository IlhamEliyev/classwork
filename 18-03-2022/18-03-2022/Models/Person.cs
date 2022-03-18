using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
        public Person(string name, string surname, int age)
        {
            if (name != "" && surname != "" && age > 0)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }
            if (age<18)
            {
                Console.WriteLine("Bu sexsin ishleme huququ yoxdur");
            }
        }
    }
}
