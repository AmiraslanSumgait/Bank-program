using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    class Operation
    {
        public Guid Id { get; set; }
        public string ProcessName { get; set; }
        public DateTime DateTime { get; set; }
        public void Show()
        {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"Process name:{ProcessName}");
            Console.WriteLine($"Date Time :{DateTime}");
        }
    }
}
