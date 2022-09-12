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
        }
    }
}
