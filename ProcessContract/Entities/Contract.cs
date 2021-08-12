﻿using System;
using System.Collections.Generic;

namespace ProcessContract.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installment { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        /*
         * adicionando parcela
         */
        public void AddInstallment(Installment installment)
        {
            Installment.Add(installment);
        }

        /*
         * removendo parcela
         */
        public void RemoveInstallment(Installment installment)
        {
            Installment.Remove(installment);
        }

    }
}
