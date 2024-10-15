using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Vezba : IEntity
    {
        public int VezbaID { get; set; }
        public string Naziv { get; set; }
        public bool Zagrevanje { get; set; }

        public string TableName => "Vezba";

        public string Values => "";

        public string UpdateValues => "";

        public string DeleteValues => "";

        public string SelectValues => "";

        public string SearchValues { get; set; }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> vezbe = new List<IEntity>();
            while (reader.Read())
            {
                Vezba vezba = new Vezba();
                vezba.VezbaID = (int)reader["VezbaID"];
                vezba.Naziv = (string)reader["Naziv"];
                vezba.Zagrevanje = (bool)reader["Zagrevanje"];
                vezbe.Add(vezba);
            }
            reader.Close();
            return vezbe;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
