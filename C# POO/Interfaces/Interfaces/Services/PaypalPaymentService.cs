using Interfaces.Entities.Interfaces;

namespace Interfaces.Services
{
    class PaypalPaymentService : IPaymentService
    {
        public double PaymentFee()
        {
            return 0.02f;
        }
        public double Interest()
        {
            return 0.01f;
        }
    }
}
