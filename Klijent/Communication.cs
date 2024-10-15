using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class Communication
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        private static Communication _instance;
        public static Communication Instance //sve pozivam preko ove public instance Singleton Pattern
        {
            get
            {
                if (_instance == null)
                    _instance = new Communication();
                return _instance;
            }
        }

        public bool Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                sender = new Sender(socket);
                receiver = new Receiver(socket);
                Console.WriteLine("Konektovan uspesno klijent!");
                return true;
            }
            catch (SocketException)
            {
                Console.WriteLine("Ne moze da se konektuje na server");
                return false;
            }

        }

        public Response Login(Korisnik korisnik)
        {
            Request request = new Request();
            request.Argument = korisnik;
            request.Operation = Operation.Login;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        public Response KreirajClana(string ime, string prezime, int meseciIskustva, Mesto mesto)
        {
            Clan clan = new Clan();
            clan.Ime = ime;
            clan.Prezime = prezime;
            clan.MeseciIskustva = meseciIskustva;
            clan.Mesto = mesto;

            Request request = new Request();
            request.Argument = clan;
            request.Operation = Operation.KreirajClana;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        public List<Mesto> UcitajListuMesta()
        {
            Request request = new Request();
            request.Operation = Operation.UcitajListuMesta;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Mesto>)response.Result;
        }

        public List<Clan> UcitajListuClanova()
        {
            Request request = new Request();
            request.Operation = Operation.UcitajListuClanova;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Clan>)response.Result;
        }

        public List<Clan> PretraziClanove(string pretraga)
        {
            Request request = new Request();
            request.Argument = pretraga;
            request.Operation = Operation.PretraziClanove;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Clan>)response.Result;
        }

        public Response IzmeniClana(Clan clan)
        {
            Request request = new Request();
            request.Argument = clan;
            request.Operation = Operation.IzmeniClana;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        public Response ObrisiClana(Clan clan)
        {
            Request request = new Request();
            request.Argument = clan;
            request.Operation = Operation.ObrisiClana;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        public Response KreirajTrenera(string ime, string prezime, string adresa)
        {
            Trener trener = new Trener();
            trener.Ime = ime;
            trener.Prezime = prezime;
            trener.Adresa = adresa;

            Request request = new Request();
            request.Argument = trener;
            request.Operation = Operation.KreirajTrenera;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        public List<Trener> UcitajListuTrenera()
        {
            Request request = new Request();
            request.Operation = Operation.UcitajListuTrenera;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Trener>)response.Result;
        }
        public List<Trener> PretraziTrenere(string pretraga)
        {
            Request request = new Request();
            request.Argument = pretraga;
            request.Operation = Operation.PretraziTrenere;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Trener>)response.Result;
        }

        public Response IzmeniTrenera(Trener trener)
        {
            Request request = new Request();
            request.Argument = trener;
            request.Operation = Operation.IzmeniTrenera;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response ObrisiTrenera(Trener trener)
        {
            Request request = new Request();
            request.Argument = trener;
            request.Operation = Operation.ObrisiTrenera;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        internal List<Vezba> UcitajListuVezbi()
        {
            Request request = new Request();
            request.Operation = Operation.UcitajListuVezbi;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Vezba>)response.Result;
        }

        public Response KreirajPlan(Plan plan, List<StavkaPlana> stavkePlana)
        {
            Request request = new Request();
            request.Argument = (plan, stavkePlana);
            request.Operation = Operation.KreirajPlan;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        internal List<Plan> UcitajListuPlanova()
        {
            Request request = new Request();
            request.Operation = Operation.UcitajListuPlanova;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Plan>)response.Result;
        }

        internal List<StavkaPlana> UcitajListuStavkiPlanova(int trenerID, int clanID)
        {
            Request request = new Request();
            request.Argument = (trenerID, clanID);
            request.Operation = Operation.UcitajListuStavkiPlanova;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<StavkaPlana>)response.Result;
        }

        internal Response IzmeniPlan(Plan plan, List<StavkaPlana> stavkePlana, List<StavkaPlana> stavkePlanaZaBrisanje)
        {
            Request request = new Request();
            request.Argument = (plan, stavkePlana, stavkePlanaZaBrisanje);
            request.Operation = Operation.IzmeniPlan;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return response;
        }

        internal IList<Plan> PretraziPlanove(string pretraga)
        {
            Request request = new Request();
            request.Argument = pretraga;
            request.Operation = Operation.PretraziPlanove;
            sender.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Plan>)response.Result;
        }
    }
}
