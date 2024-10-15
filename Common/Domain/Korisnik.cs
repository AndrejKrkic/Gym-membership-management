using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Korisnik : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string TableName => "[Korisnik]";

        public string Values => "";

        public string UpdateValues => "";

        public string DeleteValues => "";

        public string SelectValues => $"* from [Korisnik] where username='{Username}' and password='{Password}'";

        public string SearchValues { get; set; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entiteti = new List<IEntity>();
            if (reader.Read())
            {
                Console.WriteLine("DBBroker:Ima korisnika");
                Korisnik noviKorisnik = new Korisnik();
                noviKorisnik.Id = (int)reader["Korisnik_ID"];
                noviKorisnik.Ime = (string)reader["Ime"];
                noviKorisnik.Prezime = (string)reader["Prezime"];
                noviKorisnik.Username = (string)reader["Username"];
                noviKorisnik.Password = (string)reader["Password"];
                reader.Close();
                entiteti.Add(noviKorisnik);
                return entiteti;
            }
            reader.Close();
            Console.WriteLine("DBBroker: nema ovakvog korisnika");
            return null;
        }
    }
}
