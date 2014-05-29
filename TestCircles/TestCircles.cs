using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCircles
{
    class TestCircles
    {
        private double radius;
        private double diameter;
        private double area;

        public TestCircles()
        {
            this.radius = 1;
            Calc();
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                Calc();
            }
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
        }

        private void Calc()
        {
            diameter = radius * 2;
            area = Math.PI * radius * radius;
        }
     }
    class Program
    {
        public static void Main()
        {
            TestCircles testcircle = new TestCircles();

            TestCircles test1 = new TestCircles();
            TestCircles test2 = new TestCircles();
            TestCircles test3 = new TestCircles();

            test1.Radius = 5;
            test2.Radius = 100;

            Console.WriteLine("{0} -> Radius={1,5}  Diameter={2,5}  Area={3,5}", "test1", test1.Radius, test1.Diameter, test1.Area);
            Console.WriteLine("{0} -> Radius={1,5}  Diameter={2,5}  Area={3,5}", "test2", test2.Radius, test2.Diameter, test2.Area);
            Console.WriteLine("{0} -> Radius={1,5}  Diameter={2,5}  Area={3,5}", "test3", test3.Radius, test3.Diameter, test3.Area);
        }
    }
}

        
    
