using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            input.InputAmount();
            TaxCalculation taxcalculator = new TaxCalculation();
            taxcalculator.CalculateTax(input);
            Console.ReadLine();
        }
    }
}
