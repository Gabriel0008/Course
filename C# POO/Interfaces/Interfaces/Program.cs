using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Contract value: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int times = int.Parse(Console.ReadLine());

                Contract contract = new Contract(number, date, value);
                contract.installments = InstallmentService.Calculation(date, value, times, new PaypalPaymentService());

                Console.WriteLine("Installments: ");
                foreach (Installment instalment in contract.installments)
                {
                    Console.WriteLine( instalment.ToString());
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
