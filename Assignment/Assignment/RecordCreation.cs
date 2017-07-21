using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    class RecordCreation
    {
        public void CreateStudentFile(string path)
        {
            Console.WriteLine("Enter the student name ");
            string student = Console.ReadLine();
             path +="\\"+ student + ".txt";
            var writer = File.Create(path);
            writer.Close();
            StudentDetails enterstudentdetails = new StudentDetails();
            enterstudentdetails.EnterStudentDetails(path);

        }
    }
}
