using System;
using System.Globalization;
using System.Text;

namespace Heranca.Enitities
{
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual String PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $" + Price.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
