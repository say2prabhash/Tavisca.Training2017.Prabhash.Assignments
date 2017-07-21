using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
                  
            IPAddress ipAddress = IPAddress.Parse("192.168.6.53");
            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();
            TcpClient tcpclnt = new TcpClient();
            tcpclnt.Connect("192.168.6.16", 500);
            RunListener(tcpclnt);
            while (true)
            {
                String str = Console.ReadLine();
                string message = string.Format("{0}:\t {1}", name, str);
                Stream stm = tcpclnt.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(message);
                stm.Write(ba, 0, ba.Length);       

            }
            tcpclnt.Close();

        }
        public static void RunListener(TcpClient tcpclnt)
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    byte[] data = new byte[1024];

                    NetworkStream stream = tcpclnt.GetStream();
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        do
                        {
                            stream.Read(data, 0, data.Length);
                            memoryStream.Write(data, 0, data.Length);
                        } while (stream.DataAvailable);

                        string str1 = System.Text.Encoding.ASCII.GetString(memoryStream.ToArray(), 0, (int)memoryStream.Length).Trim('\0');
                        Console.WriteLine(str1);
                    }
                }
            });
        }
    }
}
    


