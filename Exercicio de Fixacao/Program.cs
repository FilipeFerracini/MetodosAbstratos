using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_de_Fixacao.Entities;

namespace Exercicio_de_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company? (i/c) ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                switch (c)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        double health = double.Parse(Console.ReadLine());
                        list.Add(new Individual(name, anualIncome, health));
                        break;
                    case 'c':
                        Console.Write("Number of Employees: ");
                        int employees = int.Parse(Console.ReadLine());
                        list.Add(new Company(name, anualIncome, employees));
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach (TaxPayer tp in list)
            {
                sum += tp.TaxAmmout();
                Console.WriteLine(tp.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
