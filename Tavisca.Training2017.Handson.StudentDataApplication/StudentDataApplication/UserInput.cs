using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class UserInput
    {
        public void ReadUpdateValues()
        {
            Console.WriteLine("Enter the file name");
            string path = Console.ReadLine();
            path = @"D:\Student\" + path + ".txt";
            Console.WriteLine("Enter the field name you want to update");
            Console.WriteLine("First Name | Last Name | Mobile Number | Email Id | Address | DOB | Course | Mentor Name | Emergency Contact");
            string field = Console.ReadLine();
            Console.WriteLine("Enter the value of the field you want to update");
            string value = Console.ReadLine();
            UpdateRecord updation = new UpdateRecord();
            updation.RecordUpdation(path, field, value);
        }
        public void ReadFilePath()
        {
           
            Console.WriteLine("Enter the file name you want to view");
            string path = Console.ReadLine();
            path = @"D:\Student\" + path + ".txt";
            RecordView viewrecord1 = new RecordView();
            viewrecord1.ViewSingleRecord(path);
        }
    }
}
