using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class OperationOptions
    {
        public void Operations()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter the following numbers to perform those operations");
                Console.WriteLine("1. To create a record of a student 2.To view all the records 3. To view a particular record 4.To update a record 5. To exit");
                int option;
                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        DirectoryCreation directory = new DirectoryCreation();
                        directory.CreateDirectory();
                        break;
                    case 2:
                        RecordView viewrecord = new RecordView();
                        viewrecord.ViewAllRecord();
                        break;
                    case 3:
                        UserInput userinput = new UserInput();
                        userinput.ReadFilePath();
                        break;
                    case 4:
                        UserInput input = new UserInput();
                        input.ReadUpdateValues();
                        break;
                    case 5:
                        loop = false;
                        break;
                    default:
                        DisplayErrorMessage display = new DisplayErrorMessage();
                        display.DisplayInvalidEntry();
                        break;
                }
            }
        }
    }
}

