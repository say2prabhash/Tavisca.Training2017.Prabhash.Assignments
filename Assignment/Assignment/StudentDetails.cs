using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StudentDetails
    {
        public void EnterStudentDetails(string path)
        {
            using (StreamWriter stream = new StreamWriter(path))
            {
                Console.WriteLine("Enter the student name");
                stream.Write("Name: "+Console.ReadLine());
            }
        }
    }
}
