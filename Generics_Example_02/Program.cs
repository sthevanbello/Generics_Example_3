using Generics_Example_02.Services;
using System;
using System.Collections.Generic;

namespace Generics_Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();


            Console.Write("Enter N: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int value = int.Parse(Console.ReadLine());
                list.Add(value);

            }

            CalculationService calculationService = new CalculationService();

            int max = calculationService.Max(list);

            Console.WriteLine($"Biggest number is: {max}");
            
            Console.ReadKey();

        }
    }
}
