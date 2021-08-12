using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessContract.Services
{
    class PaypalService : IOnlinePaymentService
    {
        /*
         * implementano a taxa de pagamento
         * do paypal 2%
         */
        public double PaymentFee(double amount)
        {
            return amount * 1.02;
        }

        /*
         *Juros simples
         */
        public double Interest (double amount, int month)
        {
            return amount * (month / 100.00) + amount;
        }
    }
}
