using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    class Client:Person
    {
        public string LiveAdress { get; set; }
        public string WorkAdress { get; set; }
        public double Salary { get; set; }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Live Adress{LiveAdress}");
            Console.WriteLine($"Work Adress{LiveAdress}");
            Console.WriteLine($"Salary{Salary}");
        }
    }
}
