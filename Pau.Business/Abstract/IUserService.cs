using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pau.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id );

        User CreateUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);
    }
}
