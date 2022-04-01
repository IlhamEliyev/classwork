using System;
using System.Text.RegularExpressions;
using User_Task.Models;
using User_Task.Utilies.Extensions;
namespace User_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Old version
            //Username:
            //Console.WriteLine("Enter the username :");
            //string username = Console.ReadLine();
            //Regex rgx = new Regex(@"^[\w\.]{6,25}$");
            //if (!rgx.IsMatch(username))
            //{
            //    Console.WriteLine("Wrong input! Please enter username again");
            //    goto Username;
            //}
            //Password:
            //Console.WriteLine("Enter the password : ");
            //string password = Console.ReadLine();
            //bool upper = false;
            //bool lower = false;
            //bool digit = false;
            //foreach (char letter in password)
            //{
            //    if (!upper)
            //    {
            //        if (Char.IsUpper(letter))
            //        {
            //            upper = true;
            //        }
            //    }
            //    if (!lower)
            //    {
            //        if (Char.IsLower(letter))
            //        {
            //            lower = true;
            //        }
            //    }
            //    if (!digit)
            //    {
            //        if (Char.IsDigit(letter))
            //        {
            //            digit = true;
            //        }
            //    }
            //}
            //if (!upper)
            //{
            //    Console.WriteLine("Password must contain at least 1 uppercase");
            //    goto Password;
            //}
            //else if (!lower)
            //{
            //    Console.WriteLine("Password must contain at least 1 lowercase");
            //    goto Password;
            //}
            //else if (!digit)
            //{
            //    Console.WriteLine("Password must contain at least 1 digit");
            //    goto Password;
            //}

            //User user = new User(username, password);
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("User.Username = " + user.Username);
            //Console.WriteLine("User.Password = " + user.Password);
            #endregion
            #region New version
            Console.WriteLine("salaM".HasLower());
            #endregion
        }
    }
}
