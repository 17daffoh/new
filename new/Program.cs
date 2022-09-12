using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    class Program
    {
        static void Main(string[] args)
        {
            // repeat 24 times
            for (int i = 0; i < 24; i++)
            {
                Console.WriteLine($"Give me {i} more!");
            }

            // repeat until user inputs yes
            bool areWeNearlyThereYet = false;

            while (areWeNearlyThereYet == false)
            {
                Console.WriteLine("Are we nearly there yet? ");
                areWeNearlyThereYet = Console.ReadLine().ToLower() == "yes";
            }

            // repeats from 1 to 50
            for (int i = 0; i < 50; i++)
            {
                //say if number is even or odd
                string oddOrEven = "odd";
                if (i % 2 == 0)
                {
                    oddOrEven = "even";
                }
                Console.WriteLine($"{i} is {oddOrEven}");
            }
            
             // count to 50
            for (int i = 0; i < 50; i++)
            {
                //say if number is divisible
                string divByThree = "divisible by three";
                if (i % 3 != 0)
                    {
                        divByThree = "not divisible by three";
                    }
                    Console.WriteLine($"{i} is {divByThree}");
            }
        }
    }
}
