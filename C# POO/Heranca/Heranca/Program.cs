using System;
using System.Collections.Generic;
using System.Globalization;
using Heranca.Enitities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();
            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i< number; i++)
            {
                Console.WriteLine("Product #"+(i+1)+" data:");
                Console.Write("Common, used or imported (c/u/i)? : ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(choice == 'c')
                {
                    produtos.Add(new Product(name, price));
                }
                else if(choice == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new UsedProduct(date, name, price));
                }
                else if(choice == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    produtos.Add(new ImportedProduct(customfee, name, price));
                }
            }
            Console.WriteLine("PRICE TAGS");
            foreach(Product product in produtos)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
