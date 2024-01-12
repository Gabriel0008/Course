using System;
using System.Globalization;
using System.Text;

namespace Heranca.Enitities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (used) $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufacture date: "+ ManufactureDate.ToShortDateString()+ ")");
            return sb.ToString();

        }
    }
}
