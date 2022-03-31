using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 1;
            while (key >0 && key <3)
            {
                Console.WriteLine("1. Square\n2. Rectangular\n0. Quit");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Side:
                        Console.WriteLine("Enter side of Square : ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        if (side > 0)
                        {
                            Square square = new Square(side);
                            Console.WriteLine(square.CalcArea());
                        }
                        else
                        {
                            Console.WriteLine("Please enter correct input");
                            goto Side;
                        }
                        break;
                    case 2:
                        WidthHeight: 
                        Console.WriteLine("Please enter the square width");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the square length");
                        double length = Convert.ToDouble(Console.ReadLine());
                        if (width>0 && length > 0)
                        {
                            Rectangular rectangular = new Rectangular(width, length);
                            Console.WriteLine(rectangular.CalcArea());
                        }
                        else
                        {
                            goto WidthHeight;
                        }
                        break;
                    default:
                        key = 3;
                        break;
                }
            }
        }
    }
}
