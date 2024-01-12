using System;
using System.Collections.Generic;
using System.Globalization;
using ExceptionTreatment.Entities;
using ExceptionTreatment.Entities.Exceptions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTreatment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, limit);

                Console.WriteLine("");
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);
                Console.WriteLine("New balance = " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: "+e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
