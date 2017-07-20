using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumber
{
    class Computation
    {
        public void ComputePower(Input input)
        {
            int number = input.GetNumber();
            int exponent = input.GetExponent();
            if (exponent == 0)
            {
                number = 0;
            }
            else if (exponent > 1)
            {
                for (int i = number, j = 0; j < exponent - 1; j++)
                {
                    number *= i;

                }
            }
           
            DisplayMessage display = new DisplayMessage();
            display.DisplayPowerofNumber(number);
        }
    }
}
