using System;
using System.Collections.Generic;

namespace delimenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Food = new Dictionary<string, string>();

            Food["$5.00"] = "turkey";
            Food["$4.00"] = "beef";
            Food["$6.00"] = "veggie";

            Console.WriteLine("here are the type of deli");
            foreach (var pair in Food)
            {
                Console.WriteLine(pair.Value);
            }


            Console.WriteLine("\nhere are the cost of deli");
            foreach (var pair in Food)
            {
                Console.WriteLine(pair.Key);
            }

            while (true)
            {
                Console.WriteLine("\n Let's add a new food");
                Console.Write("\n Enter the cost");
                string cost = Console.ReadLine();
                Console.Write("Enter the type of deli");
                string deli = Console.ReadLine();
                Food[cost] = deli;

                Console.WriteLine("\n Here are the cost and deli type");
                foreach (var pair in Food) 
                {
                    Console.WriteLine($"{pair.Key} is a {pair.Value}");
                
                }
                break;




            }

        }
    }
}
