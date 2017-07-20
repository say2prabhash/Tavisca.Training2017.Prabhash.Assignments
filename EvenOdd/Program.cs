using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            OddEven oddeven = new OddEven();
            DisplayMessage display = new DisplayMessage();
            bool check;
            input.InputNumber();
            check=oddeven.CheckEven_Odd(input.GetNumber());
            if(check==true)
            {
                display.DisplayOdd();
            }
            else
            {
                display.DisplayEven();
            }
            Console.ReadLine();
        }
    }
}
