using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbstract.Entities
{
    class Individual:TaxPayer
    {
        public double HealthExp { get; set; }


        public Individual(string name, double anualIncome, double healthExp) : base(name,anualIncome)
        {
            HealthExp = healthExp;
        }

        public override double Taxes()
        {
            double taxValue;
            if(AnualIncome >= 20000.0)
            {
                if (HealthExp > 0) {taxValue = (AnualIncome * 0.25) - (HealthExp * 0.5);return taxValue;}
                else { taxValue = (AnualIncome * 0.25); return taxValue; }
            }
            else
            {
                if (HealthExp > 0) { taxValue = (AnualIncome * 0.15) - (HealthExp * 0.5); return taxValue; }
                else { taxValue = (AnualIncome * 0.15); return taxValue; }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + ": $ " + Taxes().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
