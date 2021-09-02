using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_49
{
    class Square
    {        
        public double Length { get; set; }
       
        public double Perimeter
        {
            get
            {
                double perimeter = Length*4; // calculate perimeter of square
                return perimeter;
            }
        }
        public double Area
        {
            get
            {
                double area = Length * Length;  // calculate area of square
                return area;
            }
        }

        public Square(double Length)
        {
            this.Length = Length;
        }
        
        
    }
}
