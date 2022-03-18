using System;
using Models;

namespace _18_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //double salary = Convert.ToDouble(Console.ReadLine());
            //int hour = Convert.ToInt32(Console.ReadLine());
            Worker Ershad = new Worker(50,10,"Ershad","Teymurov", 16);
            Console.WriteLine(Ershad.name + " " + Ershad.surname +" " + Ershad.age); 
            Console.WriteLine(Ershad.CalculateSalary());
        }
        static void Test() {
            Console.WriteLine("aslkdfkdjf");
        }
    }
}
