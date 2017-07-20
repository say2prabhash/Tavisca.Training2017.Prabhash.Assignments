using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class TaxCalculation
    {
        public void CalculateTax(Input input)
        {
            double amount = input.GetAmount();
            double tax;
            if(amount >=0 && amount<10000)
            {
                tax = (double)(0.05 * amount);
            }
            else if(amount>=10000 && amount<=100000)
            {
                tax = (double) (0.08 * amount);
            }
            else
            {
                tax = (double) (0.085 * amount);
            }
            DisplayMessage display = new DisplayMessage();
            display.DisplayCalculatedTax(tax);
        }
    }
}
