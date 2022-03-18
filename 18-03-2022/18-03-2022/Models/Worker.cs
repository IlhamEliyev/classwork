using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Worker:Person
    {
        public double salaryPerHour;
        public int workingHour;
        public Worker(double salary, int hour,string name, string surname, int age):base(name,surname,age)
        {
            if (hour <= 240 && hour > 0 && salary > 0)
            {
                workingHour = hour;
                salaryPerHour = salary;
            }
            else
            {
                Console.WriteLine("Melumatlar duzgun deyil");
            }
        }
        public double CalculateSalary() 
        {
            double result = workingHour * salaryPerHour;
            if (result > 250)
            {
                return result;
            }
            return 0;
        }
    }
}
