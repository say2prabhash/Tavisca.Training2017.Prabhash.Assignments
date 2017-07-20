using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            DisplayMessage displaydata = new DisplayMessage();
            bool check = true, check_loop = true;
            while (check_loop)
            {
                Console.WriteLine("Enter your details accordingly");
                check = input.InputDetails();
                if (check == true)
                {
                    displaydata.DisplayDetails(input);
                    check_loop = false;
                }
                else
                {
                    displaydata.DisplayIncorrectData();
                }

            }
            Console.ReadLine();
        }
    }
}

