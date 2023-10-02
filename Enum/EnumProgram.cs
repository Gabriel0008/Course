using CursoPOO.Entities;
using CursoPOO.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    class EnumProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);
            
            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), out status);

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? : ");
            int quantityItens = int.Parse(Console.ReadLine());
            
            for(int i = 0; i< quantityItens; i++)
            {
                Console.WriteLine("Enter "+(i+1)+"º item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order.AddItem(orderItem);

            }



            Console.WriteLine(order.ToString());
            //Console.WriteLine(name + " "+ email + " " + date.ToShortDateString());


        }
    }
}
