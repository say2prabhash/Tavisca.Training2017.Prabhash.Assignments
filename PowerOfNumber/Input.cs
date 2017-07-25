using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumber
{
    class Input
    {
        private int number;
        private int exponent;
        public void InputNumber()
        {
            Console.WriteLine("Enter the number");
            int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Enter the exponent");
            int.TryParse(Console.ReadLine(), out exponent);
        }
        public int GetNumber()
        {
            return number;
        }
        public int GetExponent()
        {
            return exponent;
        }
    }
}
