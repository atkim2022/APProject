using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 

namespace APProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>(); 
            bool Y;
            Y = true; 
            while (Y == true)
            {
                Console.WriteLine("What number you would like to add to sum?");
                values.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Would you like to sum another number?");    
                Console.WriteLine("Type 'Y' for yes, 'N' for no.");
                String response;
                response = Console.ReadLine();
                if (response == "Y")
                {
                    Y = true;
                }
                else
                {
                    Y = false;
                }
            }
            int sum;
            sum = SumAll(values);
            Console.WriteLine($"Your sum of values is {sum}");
        }

        public static int SumAll(List<int> values)
        {
            if (values == null) // see if list is null or 0 then throw exception 
            {
                throw new ArgumentNullException("List of sums may not be null");
            }
            if (values.Count == 0) // see if list is null or 0 then throw exception 
            {
                throw new ArgumentException("The list of values must contain at least 1 value");
            }

            int result;
            result = 0;
            foreach (int value in values)
            {
                result = result + value;
            }

            return result; 
        }


    }
}
