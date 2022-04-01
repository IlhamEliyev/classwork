using System;
using System.Collections.Generic;
using System.Text;
using User_Task.Utilies.Extensions;

namespace User_Task.Utilies.Extensions
{
    static class Extension
    {
        public static bool HasUpper(this string str)
        {
            foreach (char letter in str)
            {
                if (letter >= 65 && letter <= 90)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasLower(this string str)
        {
            foreach (char letter in str)
            {
                if (letter >= 97 && letter <= 122)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasDigit(this string str)
        {
            foreach (char letter in str)
            {
                if (letter >= 48 && letter <= 57)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
