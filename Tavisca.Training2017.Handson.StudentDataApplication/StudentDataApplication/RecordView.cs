using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment
{
    class RecordView
    {
        public void ViewAllRecord()
        {
            StudentDetails studentdetails = new StudentDetails();
            string[] allFiles = Directory.GetFiles(@"D:\Student");
            if (allFiles.Length > 0)
            {
                foreach (string s in allFiles)
                {

                    using (Stream stream = File.Open(s, FileMode.Open))
                    {
                        BinaryFormatter bformatter = new BinaryFormatter();
                        studentdetails = (StudentDetails)bformatter.Deserialize(stream);

                        DisplayDetails displaydetails = new DisplayDetails();
                        displaydetails.FileDetails(studentdetails);


                        
                    }
                }
            }
            else
            {
                DisplayErrorMessage display = new DisplayErrorMessage();
                display.DisplayDirectoryIsEmpty();
            }
        }
        public void ViewSingleRecord(string path)
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
                    DisplayDetails displaydetails = new DisplayDetails();
                    displaydetails.FileDetails(studentdetails);
                    OperationOptions options = new OperationOptions();
                    options.Operations();
                }
            }

            DisplayErrorMessage display = new DisplayErrorMessage();
            display.DisplayFileDoesNotExists();

        }
    }
}

