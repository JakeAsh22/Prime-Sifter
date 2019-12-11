using System;
using System.Collections.Generic;
using PrimeLooker;

namespace Shifting
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the number you would like to use (2 or above)");
            int userInput = int.Parse(Console.ReadLine());
            Prime finder = new Prime(userInput);
            Console.WriteLine(finder.PrimeChecker());
        }
    }
}