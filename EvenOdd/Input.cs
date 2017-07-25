using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Input
    {
        private int number;
        public void InputNumber()
        {
            Console.WriteLine("Enter the number you want to check for even odd");
            int.TryParse(Console.ReadLine(), out number);
        }
        public int GetNumber()
        {
            return number;
        }
    }
}
