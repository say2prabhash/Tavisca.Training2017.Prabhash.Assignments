using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Serializable()]
    class StudentDetails : ISerializable //This class implements ISerializable interface to serialize the student data.
    {
        internal string firstName;
        internal string lastName;
        internal string mobile;
        internal string emailid;
        internal string address;
        internal string dob;
        internal string course;
        internal string mentorName;
        internal string emergencyContact;

        public StudentDetails()
        { }

        public StudentDetails(SerializationInfo serializationinfo, StreamingContext context)
        {
            firstName = (string)serializationinfo.GetValue("FirstName:", typeof(string));
            lastName = (string)serializationinfo.GetValue("LastName:", typeof(string));
            mobile = (string)serializationinfo.GetValue("MobileNumber:", typeof(string));
            emailid = (string)serializationinfo.GetValue("EmailId:", (typeof(string)));
            address = (string)serializationinfo.GetValue("Address:", typeof(string));
            dob = (string)serializationinfo.GetValue("DOB:", typeof(string));
            course = (string)serializationinfo.GetValue("Course:", typeof(string));
            mentorName = (string)serializationinfo.GetValue("MentorName:", typeof(string));
            emergencyContact = (string)serializationinfo.GetValue("EmergencyContact:", typeof(string));
        }

        public void InputDetails(string directorypath) //This method asks the user to enter all the data about a student.
        {
            Console.WriteLine("Enter the students first name");
            this.firstName = Console.ReadLine();
            Console.WriteLine("Enter the students last name");
            this.lastName = Console.ReadLine();
            Console.WriteLine("Enter the students mobile number");
            mobile = Console.ReadLine();
            if (Validation.ValidatePhoneNumber(mobile) == false)
            {
                DisplayErrorMessage display = new DisplayErrorMessage();
                display.DisplayWrongMobileNumber(mobile);
            }
            else
            {
                Console.WriteLine("Enter students email ID");
                this.emailid = Console.ReadLine();
                Console.WriteLine("Enter the address of the student");
                this.address = Console.ReadLine();
                Console.WriteLine("Enter the date of birth of the student in the format dd/mm/yyyy");
                this.dob = Console.ReadLine();
                Console.WriteLine("Enter the course name");
                this.course = Console.ReadLine();
                Console.WriteLine("Enter the student's mentor name");
                this.mentorName = Console.ReadLine();
            }
            Console.WriteLine("Enter the student's emergency contact number");
            emergencyContact = Console.ReadLine();
            if (Validation.ValidatePhoneNumber(emergencyContact) == false)
            {
                DisplayErrorMessage display = new DisplayErrorMessage();
                display.DisplayWrongMobileNumber(emergencyContact);
            }
            else
            {

                string path = directorypath + "\\" + firstName + "_" + (mobile.ToString()) + ".txt";
                RecordCreation recordcreator = new RecordCreation();
                recordcreator.CreateStudentFile(path, this);

            }
        }

        public void GetObjectData(SerializationInfo serializationinfo, StreamingContext context) //This method serializes all the data of the student.
        {
            serializationinfo.AddValue("FirstName:", this.firstName);
            serializationinfo.AddValue("LastName:", this.lastName);
            serializationinfo.AddValue("MobileNumber:", this.mobile);
            serializationinfo.AddValue("EmailId:", this.emailid);
            serializationinfo.AddValue("Address:", this.address);
            serializationinfo.AddValue("DOB:", this.dob);
            serializationinfo.AddValue("Course:", this.address);
            serializationinfo.AddValue("MentorName:", this.mentorName);
            serializationinfo.AddValue("EmergencyContact:", this.emergencyContact);

        }

    }

}
