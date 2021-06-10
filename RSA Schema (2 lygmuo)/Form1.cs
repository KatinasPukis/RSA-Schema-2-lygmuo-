using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Schema__2_lygmuo_
{
    public partial class Form1 : Form, Iupdatable
    {
        Sender sndr = null;

        private Receiver receiver = null;
        public string folderpath = @"TempData\";
        RSADigitalKey RSADigitalKey = new RSADigitalKey();
        public Form1()
        {
            InitializeComponent();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            string message = MessageTextBox.Text;
            string path = @"C:\Users\domin\source\repos\RSA Schema(2 lygmuo)\RSA Schema(2 lygmuo)\TempData\";
            byte[] signedData = RSADigitalKey.DataMain(message);
            string result = Convert.ToBase64String(signedData);
           // byte[] decByte3 = Convert.FromBase64String(result); gauti byte atgal is string
            string fullMessage = message + "," + result;
            using (StreamWriter writetext = new StreamWriter("message.txt"))
            {
                writetext.WriteLine(fullMessage);
            }
            string messagePath = @"C:\Users\domin\source\repos\RSA Schema (2 lygmuo)\RSA Schema (2 lygmuo)\bin\Debug\message.txt";

            Thread senderThread = new Thread(() =>
            {
                sndr = new Sender(messagePath);
                sndr.Send();
            });
            senderThread.Start();
        }
        

        public void displayText(string text)
        {
            throw new NotImplementedException();
        }
    }
}
