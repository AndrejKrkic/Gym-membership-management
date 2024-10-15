using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Plan : IEntity
    {
        public Trener Trener { get; set; }
        public Clan Clan { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public string Opis { get; set; }

        public string TableName => "[Plan]";

        public string Values => $"{Trener.TrenerID}, {Clan.ClanId}, '{Naziv}', {Trajanje}, '{Opis}'";

        public string UpdateValues => $"Naziv = '{Naziv}', Trajanje = {Trajanje}, Opis = '{Opis}' WHERE TrenerID = {Trener.TrenerID} AND ClanID = {Clan.ClanId}";

        public string DeleteValues => "";

        public string SelectValues => $"p.*, t.ime as 'ImeTrenera',  c.Ime as 'ImeClana' FROM [PLAN] p JOIN Trener t ON (p.TrenerID = t.TrenerID) JOIN Clan c ON (p.ClanID = c.ClanID)";

        public string SearchValues { get; set; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> planovi = new List<IEntity>();
            while (reader.Read())
            {
                Plan plan = new Plan();
                plan.Trener = new Trener();
                plan.Clan = new Clan();
                plan.Trener.TrenerID = (int)reader["TrenerID"];
                plan.Trener.Ime = (string)reader["ImeTrenera"];
                plan.Clan.Ime = (string)reader["ImeClana"];
                plan.Clan.ClanId = (int)reader["ClanID"];
                plan.Naziv = (string)reader["Naziv"];
                plan.Trajanje = (int)reader["Trajanje"];
                plan.Opis = (string)reader["Opis"];
                planovi.Add(plan);
            }
            reader.Close();
            return planovi;
        }
    }
}
