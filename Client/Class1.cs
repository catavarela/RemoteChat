using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientProxy : IClientProxy, MarshalByRefObject
    {
        Client c;

        public void Send(string message)
        {
            c.textBox2.Text += message + '\n';
        }
    }
}
