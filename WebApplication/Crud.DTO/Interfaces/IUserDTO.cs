using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.DTO.Interfaces
{
    public interface IUserDTO
    {
        string UserName { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string Surname { get; set; }
        int Contact { get; set; }
        string Email { get; set; }
    }
}
