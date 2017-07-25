using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class InputDimensions
    {
        private int[] dimensions = new int[2];
       public InputDimensions(int a,int b)
        {
            dimensions[0] = a;
            dimensions[1] = b;
        }
        public int[] GetDimensions()
        {
            return this.dimensions;
        }
    }
}
