using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class OddEven
    {
        public bool CheckEven_Odd(int number)
        {
            if(number%2!=0)
            {
                return true;
            }
            return false;
        }
    }
}
