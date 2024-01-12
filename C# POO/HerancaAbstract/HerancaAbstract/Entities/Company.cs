using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbstract.Entities
{
    class Company: TaxPayer
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double anualIncome,int employeesNumber): base(name,anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Taxes()
        {
            double taxValue;
            if (EmployeesNumber > 10)
            {
                taxValue = AnualIncome * 0.14;
                return taxValue;
            }
            else
            {
                taxValue = AnualIncome * 0.16;
                return taxValue;
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

