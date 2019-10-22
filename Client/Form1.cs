using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution
{
    public partial class Form1 : Form
    {
        string port;
        string message;
        IServerProxy obj;

       
        private void Connect_Click(object sender, EventArgs e)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, true);

            

            try
            {
                obj = (IServerProxy)Activator.GetObject(typeof(IServerProxy), "tcp://localhost:"+port+"/MyRemoteObjectName");

                //obj.Connect(new IClientProxy(url));

                button1.Enabled = false;
            }
            catch (SocketException)
            {
                System.Console.WriteLine("Could not locate server");
            }

        }

        private void Send_Click(object sender, EventArgs e)
        {
            //obj.Send(message);
        }

        private void Connect_TextChanged(object sender, EventArgs e)
        {
            port = textBox1.Text;
        }

        private void Send_TextChanged(object sender, EventArgs e)
        {
            message = textBox2.Text;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
