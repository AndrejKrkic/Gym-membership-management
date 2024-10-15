using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Mesto : IEntity
    {
        public int MestoID { get; set; }
        public string Naziv { get; set; }
        public string Ptt { get; set; }

        public Mesto()
        {
            
        }

        public Mesto(int mesto, string naziv, string Ptt)
        {
            this.MestoID = mesto;
            this.Naziv = naziv;
            this.Ptt = Ptt;
        }

        public override string ToString()
        {
            return Naziv;
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            
            List<IEntity> mesta = new List<IEntity>();
            while (reader.Read())
            {
                Mesto mesto = new Mesto();
                mesto.MestoID = (int)reader["MestoID"];
                mesto.Naziv = (string)reader["Naziv"];
                mesto.Ptt = (string)reader["Ptt"];
                mesta.Add(mesto);
            }
            reader.Close();
            return mesta;
        }
        public string TableName => "Mesto";

        public string Values => "";

        public string UpdateValues => "";

        public string DeleteValues => "";

        public string SelectValues => "";

        public string SearchValues { get; set; }
    }
}
