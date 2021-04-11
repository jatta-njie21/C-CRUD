using System;
using System.Collections;
using System.Runtime.Serialization;

namespace Crud.DTO
{
    [Serializable]
    [DataContract]
    
    public class CrudDTO
    {
        [DataMember(Order = 0)]public string UserName { get; set; }
        public string Password { get; set; }

       
    }
}
