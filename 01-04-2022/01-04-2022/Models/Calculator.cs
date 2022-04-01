using System;
using System.Collections.Generic;
using System.Text;

namespace _01_04_2022.Models
{
    static class Calculator
    {
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Substract(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
