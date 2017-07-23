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
        string directorypath = @"D:\Student";
        public void CreateDirectory()
        {
            if (!Directory.Exists(directorypath))
            {
                DirectoryInfo directorycreation = new DirectoryInfo(directorypath);
                directorycreation.Create();
               
                
            }
            StudentDetails studentdetails = new StudentDetails();
            studentdetails.InputDetails(directorypath);

        }
    }
}
