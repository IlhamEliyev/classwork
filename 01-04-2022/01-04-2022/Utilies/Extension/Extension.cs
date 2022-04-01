using System;
using System.Collections.Generic;
using System.Text;

namespace _01_04_2022.Utilies.Extension
{
    static class Extension
    {
        public static int Power(this int n1, int n2)
        {
            int result = 1;
            for (int i = 0; i < n2; i++)
            {
                result = result * n1; 
            }
            return result;
        }
    }
}