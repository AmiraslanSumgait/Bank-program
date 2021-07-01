using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    class Worker:Person
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Operation[]Operations { get; set; }
        private int OperationCount{ get; set; }
        public void AddOperation(Operation operation)
        {
            Operations = Operations.Concat(new Operation[] { operation }).ToArray();
        }
        public override void  Show()
        {
            base.Show();
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"StartTime: {StartTime}");
            Console.WriteLine($"EndTime: {EndTime}");
            Console.WriteLine("------------OPERATIONS------------");
            foreach (var operation in Operations)
            {
                operation.Show();
                Console.WriteLine();
            }

        }
    }
}
