using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pau.DataAccess.Abstract
{
    public interface IUserRepository
    {

        List<User> GetAllUsers();

        User GetUserById(int id);

        User CreatUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);
    }
}
