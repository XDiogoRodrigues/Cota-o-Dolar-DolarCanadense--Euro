using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class DollarCanadense: ICalculateQuote
    {
        public double Quote(double valueQuote)
        {
            return valueQuote * 3.67;
        }
    }
}
