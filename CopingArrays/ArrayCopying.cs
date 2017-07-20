using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopingArrays
{
    class ArrayCopying
    {
        public void CopyArray(Input input)
        {
            int[] array = input.GetArray();
            int[] arraycopy = new int[array.Length];
            for(int i=0;i<array.Length; i++)
            {
                arraycopy[i] = array[i];
            }
            DisplayArray display = new DisplayArray();
            display.PrintArray(arraycopy);
        }
    }
}
