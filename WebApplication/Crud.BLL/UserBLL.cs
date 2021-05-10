using Crud.BLL.Interfaces;
using Crud.DAL.Interfaces;
using Crud.DTO;
using Crud.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.BLL
{
    public class UserBLL
    {
        private IUserDAL _dalProvider;

        public List<IUserDTO> GetUserByID(long userID)
        {
            return _dalProvider.GetUserByID(userID);
        }

        public IUserDTO CreateNewUser(IUserDTO newUser)
        {
            return _dalProvider.CreateUserRecord(newUser);
        }

        public long DeleteUserRecord(long ID)
        {
            return _dalProvider.DeleteUser(ID);
        }
    }
}
