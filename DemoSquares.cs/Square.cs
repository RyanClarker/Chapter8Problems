using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSquares.cs
{
    class Square
    {
        private double area;
        private double length;
            
        public Square(int length)
        {
            this.length = length;
            Calc();
        }

        private void Calc()
        {
            area = length * length;
        }

        public double Side
        {
            get
            {
                return length;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
        }
    }

    class DemoSquares
    {

        public static void Main()
        {
            Square[] squares = new Square[11];

            for (int i = 1; i < squares.Length; i++)
            {
                squares[i] = new Square(i+5);

                Console.WriteLine("{0} is the length of each side, {1} is the area.", i, i * i);
            }
            
        }
    }
}


            
