using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Configuration;

namespace Seminarski_Andrej_Krkic_2020_0206
{
    public class Server
    {
        Socket osluskujuciSoket;
        public List<ClientHandler> clients = new List<ClientHandler>();
        public Server()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));
            osluskujuciSoket.Bind(endPoint);
            osluskujuciSoket.Listen(5);

            Thread thread = new Thread(PovezujKlijente);
            thread.Start();
        }

        public void Stop()
        {
            osluskujuciSoket.Close();
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //izbaci usere
            //foreach (ClientHandler clientHandler in clients)
            //{
            //    NetworkStream networkStream = new NetworkStream(clientHandler.klijentskiSoket);
            //    BinaryFormatter binaryFormatter = new BinaryFormatter();
            //    Zahtev zahtev = new Zahtev();
            //    zahtev.operation = Operation.IzbaciKlijenta;
            //    binaryFormatter.Serialize(networkStream, zahtev);
            //    clientHandler.klijentskiSoket.Shutdown(SocketShutdown.Both);
            //    clientHandler.klijentskiSoket.Close();

            //}
            //clients.Clear();
        }

        public void PovezujKlijente()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = osluskujuciSoket.Accept();
                    ClientHandler clientHandler = new ClientHandler(klijentskiSoket);
                    Thread klijentskaNit = new Thread(clientHandler.HandleClient);
                    klijentskaNit.Start();

                    clients.Add(clientHandler);
                    Console.WriteLine("Povezan je klijent");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ugasen je server");
            }
            
        }

    }
}
