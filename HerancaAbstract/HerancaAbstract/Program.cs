using System;
using System.Collections.Generic;
using HerancaAbstract.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerancaAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i< number; i++)
            {
                Console.WriteLine("Tax payer #" + (i+1) +" data:");
                Console.Write("Individual or company? (i/c)? ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(choice == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, income, health));
                }else if(choice == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employeesNumber = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, income, employeesNumber));
                }

            }
            Console.WriteLine("TAXES PAID: ");
            double sum = 0;
            foreach(TaxPayer payer in taxPayers)
            {
                Console.WriteLine(payer.ToString());
                sum += payer.Taxes();
            }
            Console.WriteLine("TOTAL TAXES $ "+ sum);
        }
    }
}
