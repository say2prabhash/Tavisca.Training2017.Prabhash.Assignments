using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment
{
    class UpdateRecord
    {
        public void RecordUpdation(string path,string key,string value) //This method updates a particular field of a file specified by the user.
        {
            string[] filePaths = Directory.GetFiles(@"D:\Student");
            foreach (string s in filePaths)
            {
                if (s.Equals(path))
                {
                    StudentDetails studentdetails = new StudentDetails();
                    Stream stream = File.Open(s, FileMode.Open);
                    BinaryFormatter bformatter = new BinaryFormatter();
                    studentdetails = (StudentDetails)bformatter.Deserialize(stream);
                    stream.Close();
                    Stream stream1 = File.Open(s, FileMode.Open);
                    BinaryFormatter bformatter1 = new BinaryFormatter();
                    if (key.Equals("First Name"))
                    {
                        studentdetails.firstName = value;
                    }
                    else if (key.Equals("Last Name"))
                    {
                        studentdetails.lastName = value;
                    }
                    else if (key.Equals("Mobile Number"))
                    {
                        studentdetails.mobile = value;
                    }
                    else if (key.Equals("Email Id"))
                    {
                        studentdetails.emailid = value;
                    }
                    else if (key.Equals("Address"))
                    {
                        studentdetails.address = value;
                    }
                    else if (key.Equals("DOB"))
                    {
                        studentdetails.dob = value;
                    }
                    else if (key.Equals("Course"))
                    {
                        studentdetails.course = value;
                    }
                    else if (key.Equals("Mentor Name"))
                    {
                        studentdetails.mentorName = value;
                    }
                    else if (key.Equals("Emergency Contact"))
                    {
                        studentdetails.emergencyContact = value;
                    }
                    else
                    {
                        DisplayErrorMessage displayfieldnotexists = new DisplayErrorMessage();
                        displayfieldnotexists.FieldDoesNotExists();
                    }
                    bformatter1.Serialize(stream1, studentdetails);
                    stream1.Close();
                    OperationOptions option = new OperationOptions();
                    option.Operations();
                }
            
    
                    DisplayErrorMessage display = new DisplayErrorMessage();
                    display.DisplayFileDoesNotExists();
                }
            }
        }
    }

