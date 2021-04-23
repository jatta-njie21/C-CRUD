using Crud.BLL.Interfaces;
using Crud.DAL.Interfaces;
using Crud.DTO;
using Crud.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.BLL
{
    public class UserBLL  //IUserBLL
    {
        private IUserDAL _provider;

        //public UserDTO InsertUser(UserDTO userDTO)
        //{
        //    return _provider.CreateNewUser(userDTO);
        //}
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
