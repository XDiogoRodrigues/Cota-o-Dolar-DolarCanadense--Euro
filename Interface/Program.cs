using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice = 1;
               
                while (choice ==1)
                {
                    Console.Write("Enter the value for quote: ");
                    double valueQuote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Which quote would you line to make: (1- Dollar | 2- Dollar Canadense | 3- Euro)\nChoice: ");
                    int choiceQuote = int.Parse(Console.ReadLine());

                    Choice.ChoiceQuote(choiceQuote, valueQuote);
                   
                    Console.Write("Are you would like to do other quote (1 - Yes | 2 - No)\nChoice: ");
                    choice = int.Parse(Console.ReadLine());
                }
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
