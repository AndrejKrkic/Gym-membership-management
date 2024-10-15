using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski_Andrej_Krkic_2020_0206
{
    public class ClientHandler
    {
        Socket klijentskiSoket;
        Receiver receiver;
        Sender sender;

        public ClientHandler(Socket klijentskiSoket)
        {
            this.klijentskiSoket = klijentskiSoket;
            receiver = new Receiver(klijentskiSoket);
            sender = new Sender(klijentskiSoket);
        }

        public void HandleClient()
        {
            try
            {
                while (true)
                {
                    Request request = (Request)receiver.Receive();
                    Response response = ProcessRequest(request);
                    sender.Send(response);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public Response ProcessRequest(Request request)
        {
            Response response = new Response();

            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Instance.Login((Korisnik)request.Argument);
                        break;
                    case Operation.KreirajClana:
                        Controller.Instance.KreirajClana((Clan)request.Argument);
                        break;
                    case Operation.UcitajListuMesta:
                        response.Result = Controller.Instance.UcitajListuMesta();
                        break;
                    case Operation.UcitajListuClanova:
                        response.Result = Controller.Instance.UcitajListuClanova();
                        break;
                    case Operation.PretraziClanove:
                        response.Result = Controller.Instance.PretraziClanove((string)request.Argument);
                        break;
                    case Operation.IzmeniClana:
                        Controller.Instance.IzmeniClana((Clan)request.Argument);
                        break;
                    case Operation.ObrisiClana:
                        Controller.Instance.ObrisiClana((Clan)request.Argument);
                        break;
                    case Operation.KreirajTrenera:
                        Controller.Instance.KreirajTrenera((Trener)request.Argument);
                        break;
                    case Operation.UcitajListuTrenera:
                        response.Result = Controller.Instance.UcitajListuTrenera();
                        break;
                    case Operation.PretraziTrenere:
                        response.Result = Controller.Instance.PretraziTrenere((string)request.Argument);
                        break;
                    case Operation.IzmeniTrenera:
                        Controller.Instance.IzmeniTrenera((Trener)request.Argument);
                        break;
                    case Operation.ObrisiTrenera:
                        Controller.Instance.ObrisiTrenera((Trener)request.Argument);
                        break;
                    case Operation.UcitajListuVezbi:
                        response.Result = Controller.Instance.UcitajListuVezbi();
                        break;
                    case Operation.KreirajPlan:
                        Controller.Instance.KreirajPlan(((Plan, List<StavkaPlana>))request.Argument);
                        break;
                    case Operation.UcitajListuPlanova:
                        response.Result = Controller.Instance.UcitajListuPlanova();
                        break;
                    case Operation.UcitajListuStavkiPlanova:
                        response.Result = Controller.Instance.UcitajListuStavkiPlanova(((int, int))request.Argument);
                        break;
                    case Operation.IzmeniPlan:
                        Controller.Instance.IzmeniPlan(((Plan, List<StavkaPlana>, List<StavkaPlana>))request.Argument);
                        break;
                    case Operation.PretraziPlanove:
                        response.Result = Controller.Instance.PretraziPlanove((string)request.Argument);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                Debug.WriteLine(ex.Message);
            }

            return response;
        }
    }
}
