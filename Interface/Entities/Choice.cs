using System;
using System.Globalization;

namespace Interface
{
    class Choice
    {
        public static void ChoiceQuote(int choice, double valueQuote)
        {
            if (choice == 1)
            {
                DateQuote date = new DateQuote(valueQuote, new QuoteDollar());
                Console.WriteLine($"------ Quote for dollar American -------");
                Console.WriteLine($"Value Total: R$ {date.CalculateQuote1.Quote(valueQuote).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();

            }
            else if (choice == 2)
            {
                DateQuote date = new DateQuote(valueQuote, new DollarCanadense());
                Console.WriteLine($"------ Quote for dollar Canadense -------");
                Console.WriteLine($"Value Total: R$ {date.CalculateQuote1.Quote(valueQuote).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();


            }
            else if (choice == 3)
            {
                DateQuote date = new DateQuote(valueQuote, new QuoteEuro());
                Console.WriteLine($"----------- Quote for Euro -------------");
                Console.WriteLine($"Value Total: R$ {date.CalculateQuote1.Quote(valueQuote).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
            }

        }
    }
}
