using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    class Bank
    {
        public Ceo Ceo { get; set; }
        public Worker[] Workers { get; set; }
        public Manager[] Managers { get; set; }
        public Credit[] Credits { get; set; }
        public string Name { get; set; }
        public double Budget { get; set; }
        private double Profit { get; set; }
        public void CalculateProfit()
        {
            foreach (var credit in Credits)
            {
               Profit+= credit.CalculatePercent(credit.Percent);
            }
            Console.WriteLine($"Bank Profit:{Profit}");
        }
        public void ShowClientCredit(string fullname)
        {
            foreach (var credit in Credits)
            {
                if (credit.Client.Name == fullname)
                {
                    Console.WriteLine($"Credit amount: {credit.Amount}");
                    Console.WriteLine($"Credit payment: {credit.Payment}");
                    Console.WriteLine($"Credit percentage: {credit.Percent}");
                }

            }
        }
        public void PayCredit(Client client,double money)
        {
            foreach (var credit in Credits)
            {
                if (credit.Client.Name == client.Name)
                {
                    credit.Amount -= money;
                    if (credit.Amount > 0)
                    {
                        Console.WriteLine($"Client paid {money} Azn all of the credit amount");
                    }
                    else
                    {
                        credit.Amount = 0;
                        Console.WriteLine("Client paid all of the money");
                    }
                }
            }
        }
        public void ShowAllCredit()
        {
            int i = 0;
            foreach (var credit in Credits)
            {
                ++i;
                Console.WriteLine($"Credit payment {i}:{credit.Payment}");
            }
        }
    }
}
