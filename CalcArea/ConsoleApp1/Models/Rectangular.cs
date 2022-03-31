using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Rectangular : Figure
    {
        private double _width;
        private double _length;
        public double Width 
        { 
            get { return _width; }
            set 
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        public Rectangular(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public override double CalcArea()
        {
            return Width * Length;
        }
    }
}
