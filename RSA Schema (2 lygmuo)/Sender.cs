using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Schema__2_lygmuo_
{
    class Sender
    {
        private List<TcpClient> clients = new List<TcpClient>();
        private string fileName;
        private string message;

        public Sender(string fileName)
        {
            this.fileName = fileName;
        }

        public void Send()
        {

            try
            {
                IPAddress receiverIP = IPAddress.Parse("192.168.43.159");
                IPEndPoint endPoint = new IPEndPoint(receiverIP, 2021);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


                byte[] fileNameBytes = Encoding.ASCII.GetBytes(Path.GetFileName(fileName));
                byte[] fileNameLength = BitConverter.GetBytes(Path.GetFileName(fileName).Length);
                byte[] fullBuffer = new byte[4 + fileNameBytes.Length];

                fileNameLength.CopyTo(fullBuffer, 0);
                fileNameBytes.CopyTo(fullBuffer, 4);

                socket.Connect(endPoint);
                socket.SendFile(fileName, fullBuffer, null, TransmitFileOptions.UseDefaultWorkerThread);
                socket.Close();
            }
            catch
            {
                Console.WriteLine("Could not connect to receiver!");
            }

        }
    }
}
