using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class QuoteEuro : ICalculateQuote
    {
        public double Quote(double valueQuote)
        {
            return valueQuote * 5.37;
        }
    }
}
