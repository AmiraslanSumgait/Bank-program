using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    abstract class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public virtual void Show()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
