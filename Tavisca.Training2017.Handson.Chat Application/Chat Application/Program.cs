using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Chat_Application
{
    class Program
    {
        static void Main(string[] args)
        {
          

            bool check = true;
            try
            {
                while (check)
                {

                    IPAddress ipAdress = IPAddress.Parse("192.168.6.53");
                  
                    TcpListener myList = new TcpListener(ipAdress, 8000);
                    Console.WriteLine("Server running - Port: 8000");
                    Console.WriteLine("Local end point:" + myList.LocalEndpoint);
                    myList.Start();
                    Socket s = myList.AcceptSocket();
                    IPAddress ipAdressclient = IPAddress.Parse(((IPEndPoint)s.RemoteEndPoint).Address.ToString());
                    string port = ((IPEndPoint)(s.RemoteEndPoint)).Port.ToString();
                    string str = "";
                    str = s.ToString();

                    byte[] b = new byte[100];
                    int k = s.Receive(b);
                    Console.WriteLine("Recieved...");

                    for (int i = 0; i < k; i++)
                    {
                        Console.Write(Convert.ToChar(b[i]));
                    }
                    s.Close();
                    myList.Stop();
                }

            }
            catch(SocketException e)
            {
                Console.WriteLine(e);
            }

            }

    }
}

