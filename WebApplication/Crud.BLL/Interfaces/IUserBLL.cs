using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.BLL.Interfaces
{
    public interface IUserBLL
    {
        void InsertUser(UserDTO userDTO);
        UserDTO GetUser(UserDTO user);
        Boolean DeleteUser();
    }
}
