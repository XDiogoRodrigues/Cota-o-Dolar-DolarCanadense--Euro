using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class DateQuote
    {
        public double ValueQuote { get; set; }
        public ICalculateQuote CalculateQuote1;

        public DateQuote(double valueQuote, ICalculateQuote calculateQuote)
        {
            ValueQuote = valueQuote;
            CalculateQuote1 = calculateQuote;
        }
    }
}
