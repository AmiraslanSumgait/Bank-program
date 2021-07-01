using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    class Credit
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public double Amount { get; set; }
        public double Percent { get; set; }
        public int Months { get; set; }
        public double Payment { get; set; }
        public Credit(Guid id,Client client,double amount,double percent,int months)
        {
            Id = id;
            Client = client;
            Amount = amount;
            Percent = percent;
            Months = months;
            Payment = CalculatePercent(percent);
        }
        public double  CalculatePercent(double percent)
        {
            return (Amount * (100 + Percent) / 100) / Months;
        }
        public void Show()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Client name: {Client.Name}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Percent: {Percent}");
            Console.WriteLine($"Months: {Months}");
            Console.WriteLine($"Payment: {Payment}");

        }
    }
}
