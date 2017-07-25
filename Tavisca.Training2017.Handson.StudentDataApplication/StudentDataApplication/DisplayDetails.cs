using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class DisplayDetails
    {
        public void FileDetails(StudentDetails studentdetails) //This methods displays all the data about a student present in a file.
        {
            Console.WriteLine("First Name: {0}", studentdetails.firstName);
            Console.WriteLine("Last  Name:{0} ", studentdetails.lastName);
            Console.WriteLine("Mobile Number:{0}", studentdetails.mobile);
            Console.WriteLine("Email Id:{0}", studentdetails.emailid);
            Console.WriteLine("Address:{0}", studentdetails.address);
            Console.WriteLine("DOB:{0}", studentdetails.dob);
            Console.WriteLine("Course:{0}", studentdetails.course);
            Console.WriteLine("Mentor Name:{0}", studentdetails.mentorName);
            Console.WriteLine("Emergency Contact Number:{0}", studentdetails.emergencyContact);
            Console.WriteLine();
            Console.WriteLine();
           
        }
    }
}
