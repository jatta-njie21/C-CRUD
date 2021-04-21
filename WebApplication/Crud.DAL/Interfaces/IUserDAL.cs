using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.DAL.Interfaces
{
    public interface IUserDAL
    {
        void CreateNewUser(UserDTO user);
    }
}
