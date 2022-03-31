using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Square:Figure
    {
        private double _side;
        public double Side 
        { 
            get { return _side; } 
            set {
                if (value > 0)
                {
                    _side = value;
                }
            } 
        }
        public Square(double side)
        {
            Side = side;
        }

        public override double CalcArea()
        {
            return Side * Side;
        }
    }
}
