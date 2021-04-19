using Crud.BLL.Interfaces;
using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.BLL
{
    public class UserBLL : IUserBLL
    {
        public void InsertUser()
        {
            //insert userdata
        }
        public UserDTO GetUser(UserDTO user)
        {
            return user;
        }
        public Boolean DeleteUser()
        {
            return true;
        }
    }
}
