using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Task.Models
{
    class User
    {
        private string _username;
        private string _password;
        public string Username { 
            get 
            {
                return _username;
            }
            set
            {
                Regex rgx = new Regex(@"^[\w\.]{6,25}$");
                if (rgx.IsMatch(value))
                {
                    _username = value.ToLower();
                }
            }
        }
        public string Password {
            get 
            {
                return _password;
            }
            set
            { 
                bool upper = false;
                bool lower = false;
                bool digit = false;
                foreach (char letter in value)
                {
                    if (!upper)
                    {
                        if (Char.IsUpper(letter))
                        {
                            upper = true;
                        }
                    }
                    else if (!lower)
                    {
                        if (Char.IsLower(letter))
                        {
                            lower = true;
                        }
                    }
                    else if(!digit)
                    {
                        if (Char.IsDigit(letter))
                        {
                            digit = true;
                        }
                    }
                }
                if (upper == true && lower == true && digit == true)
                {
                    _password = value;
                }
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
