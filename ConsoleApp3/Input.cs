using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    class Input
    {
        private string name;
        private string city;
        private string street;
        private int zipcode;
        private string house_number;
        public bool InputDetails()
        {
            bool check = false;
            int count = 1;
            DisplayMessage displayerror = new DisplayMessage();
            Validation validatezipcode = new Validation();
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the city name you live in");
            city = Console.ReadLine();
            Console.WriteLine("Enter the street name you live in");
            street = Console.ReadLine();
            while (check ==false && count<=3)
            {
               
                Console.WriteLine("Enter the zipcode of your city ");
                int.TryParse(Console.ReadLine(), out zipcode);
                check = validatezipcode.ValidateZipCode(zipcode);
                if (check !=true && count<=3)
                {
                    displayerror.DisplayZipCodeError();
                    count++;
                }
            }
            if (count <= 3)
            {
                Console.WriteLine("Enter your house number");
                house_number = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                return true;
            }
            return false;
            
        }
        public void GetDetails(Input input)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Name : " + input.name);
            Console.WriteLine("City : " + input.city);
            Console.WriteLine("Street  : " + input.street);
            Console.WriteLine("Zipcode : " + input.zipcode);
            Console.WriteLine("House Number : " + input.house_number);
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
