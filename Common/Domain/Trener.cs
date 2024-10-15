using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Trener : IEntity
    {
        public int TrenerID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }

        public string TableName => "Trener";

        public string Values => $"'{Ime}', '{Prezime}', '{Adresa}'";

        public string UpdateValues => $"Adresa = '{Adresa}' WHERE TrenerID = {TrenerID}";

        public string DeleteValues => $"TrenerID = {TrenerID}";

        public string SelectValues => "";

        public string SearchValues { get; set; }


        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> treneri = new List<IEntity>();
            while (reader.Read())
            {
                Trener trener = new Trener();
                trener.TrenerID = (int)reader["TrenerID"];
                trener.Ime = (string)reader["Ime"];
                trener.Prezime = (string)reader["Prezime"];
                trener.Adresa = (string)reader["Adresa"];
                treneri.Add(trener);
            }
            reader.Close();
            return treneri;
        }

        public override string ToString()
        {
            return Ime;
        }
    }
}
