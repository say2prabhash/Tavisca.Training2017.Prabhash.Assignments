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
        public void CreateStudentFile(string path, StudentDetails studentdetails)
        {
            if (!File.Exists(path))
            {
                var writer = File.Create(path);
                writer.Close();
                DataWriter datawriter = new DataWriter();
                datawriter.FileWriting(path, studentdetails);
            }
            else
            {
                DisplayErrorMessage display = new DisplayErrorMessage();
                display.DisplayFileAlreadyExists(path);
            }
        }
    }
}
