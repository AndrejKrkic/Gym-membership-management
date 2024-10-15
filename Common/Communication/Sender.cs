using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sender
    {
        private NetworkStream networkStream;
        private BinaryFormatter binaryFormatter;

        public Sender(Socket socket)
        {
            networkStream = new NetworkStream(socket);
            binaryFormatter = new BinaryFormatter();
        }

        public void Send(object argument)
        {
            binaryFormatter.Serialize(networkStream, argument);
        }
    }
}
