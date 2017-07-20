using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            Computation compute = new Computation();
            input.InputNumber();
            compute.ComputePower(input);
            Console.ReadLine();
        }
    }
}
