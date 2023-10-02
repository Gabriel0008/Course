using System.Globalization;
using System.Text;

namespace Heranca.Enitities
{
    class ImportedProduct: Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(double customsFee, string name, double price) : base(name,price)
        {
            this.CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.PriceTag());
            sb.Append("(Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")");
            return sb.ToString();
        }
    }
}
