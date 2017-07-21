using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class DirectoryCreation
    {
        string path = @"D:\Student";
        public void CreateDirectory()
        {
            if (!Directory.Exists(path))
            {
                DirectoryInfo directorycreation = new DirectoryInfo(path);
                directorycreation.Create();
               
                
            }
            RecordCreation record = new RecordCreation();
            record.CreateStudentFile(path);

        }
    }
}
