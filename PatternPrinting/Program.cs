using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<9/2-i;j++)
                {
                    Console.Write(" ");
                }
                for(int j=9/2-i,k=1;j<=(9/2-i)+i;j++,k++)
                {
                    Console.Write(k);
                }
                for(int j=(9/2-i)+i,k =i;j<(9/2-i)+i+i;j++,k--)
                {
                    Console.Write(k);
                }
                for(int j= (9 / 2 - i) + i + i;j<9;j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
