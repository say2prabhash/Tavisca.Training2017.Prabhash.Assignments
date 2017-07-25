using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Input
    {
        private double amount;
        public void InputAmount()
        {
            Console.WriteLine("Enter the amount to be taxed");
            double.TryParse(Console.ReadLine(), out amount);
        }
        public double GetAmount()
        {
            return amount;
        }
    }
}
