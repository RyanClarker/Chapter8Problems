using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class HousePlant
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public bool Fed { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            HousePlant plant = new HousePlant();
            HousePlant palm = new HousePlant();
            HousePlant tree = new HousePlant();

            palm.Name = "Palm Tree";
            palm.Price = 39.95;
            palm.Fed = false;

            plant.Name = "Rose";
            plant.Price = 11.95;
            plant.Fed = true; 

            tree.Name = "Woody";
            tree.Price = 999.99;
            tree.Fed = true;

            Console.WriteLine(palm.Name);
            Console.WriteLine(palm.Price);
            Console.WriteLine(palm.Fed);
            Console.WriteLine();
            Console.WriteLine(plant.Name);
            Console.WriteLine(plant.Price);
            Console.WriteLine(plant.Fed);
            Console.WriteLine();
            Console.WriteLine(tree.Name);
            Console.WriteLine(tree.Price);
            Console.WriteLine(tree.Fed);

        }
    }
}
