using System.Collections.Generic;
using Crud.DTO.Interfaces;

namespace Crud.DAL.Interfaces
{
    public interface IUserDAL
    {
        IUserDTO CreateUserRecord(IUserDTO newUser);
        List<IUserDTO> GetUserByID(long ID);
        long DeleteUser(long userID);
        IUserDTO UpdateUser(IUserDTO updateUser);
    }
}