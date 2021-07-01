using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_program
{
    interface ICeo
    {
        void Control();
        void Organize();
        void MakeMeeting();
        void DecreasePercentage(Credit[] credits, double percent);
    }
    class Ceo:Person,ICeo
    {
        public double Salary { get; set; }
        public string Position { get; set; }
        public void Control()
        {
            Console.WriteLine("Managing the overall operations and resources of a company");
        }

        public void DecreasePercentage(Credit[]credits,double percent)
        {
            foreach (var credit in credits)
            {
                if (percent < credit.Percent)
                {
                    credit.Percent-= percent;
                }
                else if (percent > credit.Percent)
                {
                    Console.WriteLine($"Decrease percent bigger than credit percent");
                }
            }
        }

        public void MakeMeeting()
        {
            Console.WriteLine("Ceo makes meeting");
        }

        public void Organize()
        {
            Console.WriteLine("Ceo organize something");
        }
    }
}
