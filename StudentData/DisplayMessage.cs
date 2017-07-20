using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class DisplayMessage
    {
        Input displaydetails = new Input();
        public void DisplayRollNumberError()
        {
            Console.WriteLine("Please check the roll number you have entered.");
            Console.WriteLine("Either you have entered a roll number which has less than 4 digits or you may entered a roll number which does not exists ");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void DisplayDetails(Input input)
        {
            displaydetails.GetDetails(input);
        }
        public void DisplayIncorrectData()
        {
            Console.WriteLine("Incorrect data entered...Please try again");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
