using ProcessContract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessContract.Services
{
    class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinePayment)
        {
            _onlinePaymentService = onlinePayment;
        }

        /*
         * criando o contrato
         */
        public void ProcessContract(Contract contract, int monthis)
        {
            double parcela = contract.TotalValue/monthis;
            DateTime date = contract.Date;
            for(int i = 1; i<=monthis; i++)
            {
                double interest = _onlinePaymentService.Interest(parcela, i);
                date = date.AddMonths(1);
                double payment = _onlinePaymentService.PaymentFee(interest);
                Installment insta = new Installment(date, payment);
                contract.Installment.Add(insta);
            }

        }
    }
}
