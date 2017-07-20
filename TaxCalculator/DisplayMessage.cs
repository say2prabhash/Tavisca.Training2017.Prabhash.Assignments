using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class DisplayMessage
    {
        public void DisplayCalculatedTax(double tax)
        {
            Console.WriteLine("Total tax calculated = " + tax);
        }
    }
}
