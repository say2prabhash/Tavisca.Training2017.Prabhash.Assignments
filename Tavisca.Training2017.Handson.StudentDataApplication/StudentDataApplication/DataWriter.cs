using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class DataWriter
    {
        public void FileWriting(string path,StudentDetails studentdetails)
        {
            Stream stream = File.Open(path, FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing Student Information");
            bformatter.Serialize(stream, studentdetails);
            stream.Close();
            OperationOptions options = new OperationOptions();
            options.Operations();

        }
    }
}
