using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ChatGPT_Proxy_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (APIKEY.Text == "" || Message.Text == "" || IP.Text == "" || PORT.Text == "")
            {
                MessageBox.Show("Something is missing");
            } else
            {
                TcpClient client = new TcpClient(IP.Text, int.Parse(PORT.Text)); // Replace with your server IP and port
                NetworkStream stream = client.GetStream();
                string messageToSend = $"|{APIKEY.Text}|{Message.Text}";
                byte[] dataToSend = Encoding.UTF8.GetBytes(messageToSend);
                stream.Write(dataToSend, 0, dataToSend.Length);
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (receivedMessage == "ERROR")
                    MessageBox.Show("Something went wrong...");
                else
                    //MessageBox.Show(receivedMessage.Split('|')[1], "DEBUG");
                    // the elapsed time and etc are kinda useless so im not including this
                    List.Text += $"You: {Message.Text}\n";
                    List.Text += $"ChatGPT: {receivedMessage.Split('|')[1]}\n";
                client.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
