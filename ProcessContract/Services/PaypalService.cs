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
            double porc = month / 100.0;
            double service = amount * porc + amount;
            Console.WriteLine(service);
            return service;
        }
    }
}
