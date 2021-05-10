using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Crud.DTO
{
    [Serializable]
    [DataContract]
    public class ConnectionDTO
    {
        private string _dbName;
        //[DataMember(Order =0)]public string GetConnection { get; set; }

        public ConnectionDTO(string dbName)
        {
            this._dbName = dbName;
        }
    }
}
