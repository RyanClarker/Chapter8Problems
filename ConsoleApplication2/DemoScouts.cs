using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class GirlScout
    {
        private string troopName;
        private int troopNumber;
        private double dues;
        public static string motto = "to obey the Girl Scout law.";

        public string TroopName
        {
            get
            {
                return troopName;
            }
            set
            {
                troopName = value;
            }
        }

        public int TroopNumber
        {
            get
            {
                return troopNumber;
            }
            set
            {
                troopNumber = value;
            }
        }

        public double Dues
        {
            get
            {
                return dues;
            }
            set
            {
                dues = value;
            }
        }
    }

    class DemoScouts
    {
        public static void Main()
        {
            GirlScout girlscout = new GirlScout();
            GirlScout girlscout2 = new GirlScout();

            girlscout.TroopName = "The Laughing Llamas";
            girlscout.TroopNumber = 23;
            girlscout.Dues = 99.99;

            girlscout2.TroopName = "The Hazy Hyeneas";
            girlscout2.TroopNumber = 24;
            girlscout2.Dues = 101.11;

            Console.WriteLine("Troop Name: {0}.", girlscout.TroopName);
            Console.WriteLine("Troop Number: {0}.", girlscout.TroopNumber);
            Console.WriteLine("{0}", GirlScout.motto);
            Console.WriteLine();
            Console.WriteLine("Troop Name: {0}.", girlscout2.TroopName);
            Console.WriteLine("Troop Number: {0}.", girlscout2.TroopNumber);
            Console.WriteLine("{0}", GirlScout.motto);           
        }
    }
}
