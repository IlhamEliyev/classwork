using System;
using System.Collections.Generic;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ilham", "Aliyev",21);
            Person p2 = new Person("Ershad", "Teymurlu",20);
            Person p3 = new Person("Ebu", "Sadiqov",21);
            Person p4 = new Person("Gunel", "Mustafayeva",21);
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);
            //Person FoundPerson = people.Find(p => p.Age == 21);
            //Console.WriteLine($"{FoundPerson.Name} {FoundPerson.Surname} : {FoundPerson.Age}");
            foreach (Person person in people.FindAll(p => p.Age == 21))
            {
                Console.WriteLine($"{person.Name} {person.Surname} : {person.Age}");
            }
            //foreach (var person in people)
            //{
            //    if (person.Age == 21)
            //    {
            //        Console.WriteLine($"{person.Name} {person.Surname} : {person.Age}");
            //    }
            //}
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
