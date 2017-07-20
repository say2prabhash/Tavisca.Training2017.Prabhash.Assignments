using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class Input
    {
        private string name;
        private string universityname;
        private int clas;
        private int rollnumber;
        private int age;
        public bool InputDetails()
        {
            bool check = false;
            int count = 1;
            DisplayMessage displayerror = new DisplayMessage();
            Validation validaterollnumber = new Validation();
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the class in which you study");
             int.TryParse(Console.ReadLine(),out clas);
            Console.WriteLine("Enter your age");
            int.TryParse(Console.ReadLine(),out age);
            while (check == false && count <= 3)
            {

                Console.WriteLine("Enter your roll number");
                int.TryParse(Console.ReadLine(), out rollnumber);
                check = validaterollnumber.ValidateRollNumber(rollnumber);
                if (check != true && count <= 3)
                {
                    displayerror.DisplayRollNumberError();
                    count++;
                }
            }
            if (count <= 3)
            {
                Console.WriteLine("Enter your university name");
                universityname = Console.ReadLine();
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
            Console.WriteLine("Roll Number : " + input.rollnumber);
            Console.WriteLine("Class  : " + input.clas);
            Console.WriteLine("Age : " + input.age);
            Console.WriteLine("University : " + input.universityname);
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
