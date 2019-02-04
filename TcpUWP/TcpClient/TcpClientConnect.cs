using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace PortableTcpClient
{
    public class TcpClientConnect
    {
        const string SERVER_IP = "127.0.0.1";

        public void ConnectToClinet(int port)
        {
            string textToSend = DateTime.Now.ToString();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            do
            {
                try
                {
                    TcpClient client = new TcpClient { NoDelay = true };

                    client.ConnectAsync(SERVER_IP, port).Wait();

                    NetworkStream nwStream = client.GetStream();
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

                    //---send the text---
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    client.Dispose();
                }
                catch (Exception ex)
                {
                    string local = ex.Message;
                }
            }
            while (watch.ElapsedMilliseconds < 5000);
        }
    }
}
