using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public enum Status
    {
        Unchanged,
        Added,
        Removed
    }
    [Serializable]
    public class StavkaPlana : IEntity
    {
        public Trener Trener { get; set; }
        public Clan Clan { get; set; }
        public int StavkaPlanaID { get; set; }
        public int BrojPonavljanja { get; set; }
        public int BrojSerija { get; set; }
        public Vezba Vezba { get; set; }
        public Status Status { get; set; }

        public string TableName => "StavkaPlana";

        public string Values => $"{Trener.TrenerID}, {Clan.ClanId}, {BrojPonavljanja}, {BrojSerija}, {Vezba.VezbaID}";

        public string UpdateValues => "";

        public string DeleteValues => $"TrenerID = {Trener.TrenerID} AND ClanID = {Clan.ClanId} AND StavkaPlanaID = {StavkaPlanaID}";

        public string SelectValues => $"* FROM StavkaPlana s JOIN Vezba v ON (s.VezbaID = v.VezbaID) WHERE TrenerID = {Trener.TrenerID} AND ClanID = {Clan.ClanId}";

        public string SearchValues { get; set; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> stavkePlanova = new List<IEntity>();
            while (reader.Read())
            {
                StavkaPlana stavkaPlana = new StavkaPlana();
                stavkaPlana.Vezba = new Vezba();
                stavkaPlana.Trener = new Trener();
                stavkaPlana.Clan = new Clan();
                stavkaPlana.BrojPonavljanja = (int)reader["BrojPonavljanja"];
                stavkaPlana.BrojSerija = (int)reader["BrojSerija"];
                stavkaPlana.Vezba.VezbaID = (int)reader["VezbaID"];
                stavkaPlana.Vezba.Naziv = (string)reader["Naziv"];
                stavkaPlana.StavkaPlanaID = (int)reader["StavkaPlanaID"];
                stavkePlanova.Add(stavkaPlana);
            }
            reader.Close();
            return stavkePlanova;
        }

        public StavkaPlana()
        {
            Trener = new Trener();
            Clan = new Clan();
        }
    }
}
