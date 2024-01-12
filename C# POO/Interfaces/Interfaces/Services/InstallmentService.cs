using System;
using Interfaces.Entities.Interfaces;
using Interfaces.Entities.Exceptions;
using Interfaces.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    static class InstallmentService
    {
        public static List<Installment> Calculation(DateTime initialDate, double contractValue, int installmentsNumber, IPaymentService paymentService)
        {
            List<Installment> installments = new List<Installment>();
            double unitaryValue = contractValue / installmentsNumber;
            if(installmentsNumber <=0)
            {
                throw new DomainException("Installments must be greater than 0");
            }
            for(int i = 1; i<= installmentsNumber; i++)
            {
                double installment = unitaryValue + paymentService.Interest() * unitaryValue * i + paymentService.PaymentFee() * unitaryValue;
                DateTime date = initialDate.AddMonths(i);
                installments.Add(new Installment(date, installment));
            }
            return installments;
        } 
    }
}
