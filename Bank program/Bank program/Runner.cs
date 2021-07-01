using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    class Runner
    {
        public static void Run()
        {
            Ceo ceo = new Ceo
            {
                Id = Guid.NewGuid(),
                Name = "Amiraslan",
                Surname = "Aliyev",
                Age = 18,
                Position = "Ceo",
                Salary = 5000
            };
            Operation operation1 = new Operation
            {
                DateTime = new DateTime(2021, 10, 23),
                Id = Guid.NewGuid(),
                ProcessName = "Assisting with logistical support "
            };
            Operation operation2 = new Operation
            {
                DateTime = new DateTime(2021, 9, 25),
                Id = Guid.NewGuid(),
                ProcessName = "Client Service Operations "
            };
            Operation operation3 = new Operation
            {
                DateTime = new DateTime(2021, 10, 10),
                Id = Guid.NewGuid(),
                ProcessName = "Retail Banking"
            };
            Operation operation4 = new Operation
            {
                DateTime = new DateTime(2021, 08, 20),
                Id = Guid.NewGuid(),
                ProcessName = "Corporate Banking "
            };
            Worker worker1 = new Worker
            {
                Id = Guid.NewGuid(),
                Name = "Hormet",
                Surname = "Hemidov",
                Age = 19,
                Position = "Controller",
                Salary = 1000,
                StartTime = "16:00",
                EndTime = "23:00",
                Operations = new Operation[] { operation1, operation2 }
            };
            Worker worker2 = new Worker
            {
                Id = Guid.NewGuid(),
                Name = "Hormet",
                Surname = "Hemidov",
                Age = 19,
                Position = "Controller",
                Salary = 1000,
                StartTime = "09:00",
                EndTime = "23:00",
                Operations = new Operation[] { operation3, operation4 }

            };
            Manager manager1 = new Manager
            {
                Id = Guid.NewGuid(),
                Age = 18,
                Name = "Kenan",
                Surname = "Idayatov",
                Position = "Chief Marketing Officer"
            };
            Client client1 = new Client
            {
                Id = Guid.NewGuid(),
                Name = "Kamal",
                Surname = "Eliyev",
                Age = 16,
                LiveAdress = "Sumgait 18 mkr",
                Salary = 1300,
                WorkAdress = "Student in 4 number school"
            };
            Client client2 = new Client
            {
                Id = Guid.NewGuid(),
                Name = "Ferhad",
                Surname = "Eliyev",
                Age = 16,
                LiveAdress = "Sumgait 12 mkr",
                Salary = 1100,
                WorkAdress = "Student in 4 number school"
            };
            Credit credit1 = new Credit(Guid.NewGuid(), client1, 1000, 5, 12);
            Credit credit2 = new Credit(Guid.NewGuid(), client2, 1500, 3, 12);
            Worker[] workers = new Worker[] { worker1, worker2 };
            Client[] clients = new Client[] { client1, client2 };
            Credit[] credits = new Credit[] { credit1, credit2};
            Bank bank = new Bank
            {
                Name = "Kapital Bank",
                Budget = 15700,
                Ceo = ceo,
                Workers = workers,
                Credits =credits,
                Managers = new Manager[] { manager1 }


            };
           // bank.ShowClientCredit("Ferhad");
           // bank.ShowAllCredit();
           // manager1.CalculateSalaries(ceo, clients, workers);
           // bank.PayCredit(client1, 1200);
           // ceo.DecreasePercentage(credits, 2);
        }
    }
}
