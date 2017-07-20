using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopingArrays
{
    class Input
    {
        private int[] arrays= new int[10];
        public void InputElementsIntoArray()
        {
            Console.WriteLine("Enter data into the array");
            for(int i=0;i<arrays.Length;i++)
            {
                Int32.TryParse(Console.ReadLine(), out arrays[i]);
            }
        }
        public int[] GetArray()
        {
            return arrays;
        }
    }
}
