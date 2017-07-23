using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class DisplayErrorMessage
    {
        public void DisplayFileAlreadyExists(string path)
        {
            Console.WriteLine("File with this name and path already exits" + path);
            Console.WriteLine();
            OperationOptions options = new OperationOptions();
            options.Operations();
        }
        public void DisplayWrongMobileNumber(string mobile)
        {
            Console.WriteLine("The mobile number you have entered is wrong:" + mobile);
            Console.WriteLine("Please enter a valid mobile number which has 10 digits");
            Console.WriteLine();
            OperationOptions options = new OperationOptions();
            options.Operations();
        }
        public void DisplayFileDoesNotExists()
        {
            Console.WriteLine("There is no file with such name in the current directory");
            Console.WriteLine();
            OperationOptions options = new OperationOptions();
            options.Operations();
        }
        public void DisplayDirectoryIsEmpty()
        {
            Console.WriteLine("Directory is empty");
            Console.WriteLine();
            OperationOptions options = new OperationOptions();
            options.Operations();
        }
        public void FieldDoesNotExists()
        {
            Console.WriteLine("The entered field does not exists in the file");
            Console.WriteLine();
            OperationOptions options = new OperationOptions();
            options.Operations();
        }
        public void DisplayInvalidEntry()
        {
            Console.WriteLine("Invalid entry of option");
            Console.WriteLine();
            
        }
    }
}
