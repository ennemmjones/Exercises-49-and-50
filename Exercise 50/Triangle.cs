using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_50
{
    class Triangle
    {        
        public double LengthOne { get; set; }
        
        public double LengthTwo { get; set; }
       
        public double LengthThree { get; set; }        

        public double Perimeter
        { get
            {
                double perimeter = LengthOne + LengthTwo + LengthThree; // Calculate perimeter
                return perimeter;
            }
        }
        public double Area
        {
            get
            {
                double s = Perimeter / 2;
                double area = Math.Sqrt(s * (s - LengthOne) * (s - LengthTwo) * (s - LengthThree)); // Calculate area - Heron's formula        
                return area; 
            }
        }

        public Triangle(double LengthOne, double LengthTwo, double LengthThree)
        {
            this.LengthOne = LengthOne;
            this.LengthTwo = LengthTwo;
            this.LengthThree = LengthThree;
        }
    }

}
