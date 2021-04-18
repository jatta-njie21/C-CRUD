using Crud.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Crud.DTO
{
    [Serializable]
    [DataContract]
    public class UserDTO : IUserDTO
    {
        [DataMember(Order =0)] public string UserName { get; set; }
        [DataMember(Order = 1)] public string Password { get; set; }
        [DataMember(Order = 2)] public string FirstName { get; set; }
        [DataMember(Order = 3)] public string Surname { get; set; }
        [DataMember(Order = 4)] public int Contact { get; set; }
        [DataMember(Order = 5)] public string Email { get; set; }
    }
}
