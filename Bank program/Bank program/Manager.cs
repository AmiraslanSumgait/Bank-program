using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    interface IManager
    {
        void Organize();
        void CalculateSalaries(Ceo ceo, Client[] clients, Worker[] workers);
    }
    class Manager:Person,IManager
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public void CalculateSalaries(Ceo ceo,Client[]clients,Worker[]workers)
        {
            double allSalary = 0;
            allSalary += ceo.Salary;
            foreach (var client in clients)
            {
                allSalary += client.Salary;
            }
            foreach (var worker in workers)
            {
                allSalary += worker.Salary;
            }
            Console.WriteLine($"Salary of the bank members:{allSalary}");
        }

        public void Organize()
        {
            Console.WriteLine("Manager coordinate employees");
        }
    }
}
