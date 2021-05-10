using Crud.DAL.Interfaces;
using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using Crud.DTO.Interfaces;

namespace Crud.DAL
{
    public class UserDAL : IUserDAL
    {
        ConnectionDTO connectionDTO = new ConnectionDTO(@"DESKTOP-H92A9GF\CODELESS");

        StringBuilder sqlCmd = new StringBuilder();

        //public void CreateNewUser(UserDTO user)
        //{
        //    sqlCmd.AppendLine("INSERT INTO");
        //    sqlCmd.AppendLine("[User]");
        //    sqlCmd.AppendLine("(ID,");
        //    sqlCmd.AppendLine("Username,");
        //    sqlCmd.AppendLine("Password,");
        //    sqlCmd.AppendLine("FirstName,");
        //    sqlCmd.AppendLine("Surname,");
        //    sqlCmd.AppendLine("Contact,");
        //    sqlCmd.AppendLine("Email)");
        //    sqlCmd.AppendLine("Values");
        //    sqlCmd.AppendLine("(3,");
        //    sqlCmd.AppendLine("'test3',");
        //    sqlCmd.AppendLine("'tester3',");
        //    sqlCmd.AppendLine("'test',");
        //    sqlCmd.AppendLine("'test',");
        //    sqlCmd.AppendLine("3737373,");
        //    sqlCmd.AppendLine("'tsttst')");
        //    sqlCmd.AppendLine(";");
        //    sqlCmd.AppendLine();
        //}
        public IUserDTO CreateUserRecord(IUserDTO newUser)
        {
            return new UserDTO();
        }

        public List<IUserDTO> GetUserByID(long ID)
        {
            return null;
        }

        public long DeleteUser(long userID)
        {
            return userID;
        }

        public IUserDTO UpdateUser(IUserDTO updateUser)
        {
            return new UserDTO();
        }
    }
}
