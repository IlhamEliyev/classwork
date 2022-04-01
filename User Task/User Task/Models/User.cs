using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using User_Task.Utilies.Extensions;

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
                if (value.HasDigit() && value.HasLower() && value.HasUpper())
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
