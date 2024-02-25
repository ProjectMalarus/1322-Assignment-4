using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Assignment_4
{
    internal class English : Language
    {
        public override string make_guess()
        {
            Console.WriteLine("Guess a number");
            int num = Convert.ToInt32(Console.ReadLine());

            return num.ToString();
        }

        public override string too_low()
        {
            return "Too Low";
        }

        public override string too_high()
        {
            return "Too High";
        }

        public override string correct()
        {
            return "Correct";
        }
    }
}
