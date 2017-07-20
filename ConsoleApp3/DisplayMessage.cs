using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    class DisplayMessage
    {
        Input displaydetails = new Input();
        public void DisplayZipCodeError()
        {
            Console.WriteLine("Please check the zipcode you have entered.");
            Console.WriteLine("Either you have entered a zipcode which has less than 6 digits or you may entered a zipcode which does not exists ");
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
