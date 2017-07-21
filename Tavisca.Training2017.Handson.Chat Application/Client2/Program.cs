using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ClientConnection();
            }
        }
        public static void ClientConnection()
        {
            try

            {
                Console.Write("Enter the string to be sent: ");

                String str = Console.ReadLine();
                TcpClient tcpclnt = new TcpClient();
                tcpclnt.Connect("192.168.6.53", 8000);
                Stream stm = tcpclnt.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                    stm.Write(ba, 0, ba.Length);

                    byte[] bb = new byte[100];
                    int k = stm.Read(bb, 0, 100);

                    for (int i = 0; i < k; i++)
                    {
                        Console.Write(Convert.ToChar(bb[i]));
                    }
                    
                    
                        
                            tcpclnt.Close();

                }

            
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }


           
        }
        
        
    }
}
