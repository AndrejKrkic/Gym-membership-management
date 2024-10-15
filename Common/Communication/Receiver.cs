using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Receiver
    {
        private NetworkStream _networkStream;
        private BinaryFormatter _binaryFormatter;

        public Receiver(Socket socket)
        {
            _networkStream = new NetworkStream(socket);
            _binaryFormatter = new BinaryFormatter();

        }

        public object Receive()
        {
            return _binaryFormatter.Deserialize(_networkStream);
        }
    }
}
