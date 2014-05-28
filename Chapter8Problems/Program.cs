using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8Problems
{
    class Pizza
    {
        private string topping;
        public string Topping
        {
            get
            {
                return topping;
            }
            set
            {
                topping = value;
            }
        }

        private int diameter;
        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

        private double cost;
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();

            pizza.Topping = "Cheese";
            pizza.Diameter = 12;
            pizza.Cost = 3.14;

        }
    }
}


            
