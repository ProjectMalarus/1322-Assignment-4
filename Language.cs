using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Assignment_4
{
    internal abstract class Language
    {
        public abstract string make_guess();

        public abstract string too_low();

        public abstract string too_high();

        public abstract string correct();
    }
}
