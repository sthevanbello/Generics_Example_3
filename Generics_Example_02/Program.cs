using Generics_Example_02.Entities;
using Generics_Example_02.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics_Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();
            
            Console.Write("Enter N: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = int.Parse(vect[1], CultureInfo.InvariantCulture);
                
                list.Add(new Products(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Products max = calculationService.Max(list);

            Console.WriteLine($"Biggest number is: {max}");
            
            Console.ReadKey();

        }
    }
}
