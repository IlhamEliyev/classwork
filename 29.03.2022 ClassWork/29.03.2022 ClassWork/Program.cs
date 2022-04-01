using _29._03._2022_ClassWork.Models;
using System;
using System.Text.RegularExpressions;

namespace _29._03._2022_ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter the password : ");
            string password = Console.ReadLine();
            Regex regex = new Regex(@"^[\w\.]{6,25}$");
            if (!(regex.IsMatch(username)))
            {
                Console.WriteLine("Wrong input");
            }
            User user = new User(username, password);
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);
            
        }
    }
}
