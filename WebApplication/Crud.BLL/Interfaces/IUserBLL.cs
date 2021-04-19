using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.BLL.Interfaces
{
    interface IUserBLL
    {
        void InsertUser();
        UserDTO GetUser(UserDTO user);
        Boolean DeleteUser();
    }
}
