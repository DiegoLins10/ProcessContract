using ProcessContract.Entities;
using ProcessContract.Services;
using System;
using System.Globalization;

namespace ProcessContract
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime time = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int qtdMonth = int.Parse(Console.ReadLine());


                Contract contract = new Contract(number, time, contractValue);
                ContractService contractService = new ContractService(new PaypalService());

                contractService.ProcessContract(contract, qtdMonth);

                Console.WriteLine("Installments:");
                Console.WriteLine(contract);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
        }
    }
}
