using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Clan : IEntity
    {
        public int ClanId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int MeseciIskustva { get; set; }
        public Mesto Mesto { get; set; }

        public string TableName => "Clan"; //ime tabele u sql manageru

        public string Values => $"'{Ime}', '{Prezime}', {MeseciIskustva}, {Mesto.MestoID}"; //koje kolone mi trebaju

        public string UpdateValues => $"meseciIskustva = {MeseciIskustva}, Mesto = {Mesto.MestoID} WHERE ClanID = {ClanId}";

        public string DeleteValues => $"ClanID = {ClanId}";

        public string SelectValues => $"* from Clan c JOIN Mesto m ON(c.Mesto = m.MestoID)";

        public string SearchValues { get; set; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {

            List<IEntity> entiteti = new List<IEntity>();
            while (reader.Read())
            {
                Clan clan = new Clan();
                clan.ClanId = (int)reader["ClanID"];
                clan.Ime = (string)reader["Ime"];
                clan.Prezime = (string)reader["Prezime"];
                clan.MeseciIskustva = (int)reader["meseciIskustva"];
                clan.Mesto = new Mesto();
                clan.Mesto.MestoID = (int)reader["MestoID"];
                clan.Mesto.Naziv = (string)reader["Naziv"];
                clan.Mesto.Ptt = (string)reader["Ptt"];
                entiteti.Add(clan);
            }
            reader.Close();
            return entiteti;


        }

        public override string ToString()
        {
            return Ime;
        }
    }
}
