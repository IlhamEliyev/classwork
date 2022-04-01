using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _29._03._2022_ClassWork.Models
{
    class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username
        {
            get { return username; }
            set
            {
                Regex regex = new Regex(@"^[\w\.]{6,25}$");
                if (regex.IsMatch(value))
                {
                    username = value.ToLower();
                }

            }

        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length > 8 && value.Length < 25)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsUpper(value[i]))
                        {

                        }
                        else if (Char.IsLower(value[i]))
                        {

                        }
                        else if (!Char.IsDigit(value[i]))
                        {

                        }
                        else
                        {
                            password = value;
                        }
                    }
                }
            }
        }
    }
}
