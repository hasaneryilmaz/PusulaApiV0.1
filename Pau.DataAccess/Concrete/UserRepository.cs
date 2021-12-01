using Pau.DataAccess.Abstract;
using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pau.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User CreatUser(User user)
        {
            using (var userDbContext = new PauDbContext())
            {
                userDbContext.Users.Add(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (var userDbContext = new PauDbContext())
            {
                var DeletedUser = GetUserById(id);

                userDbContext.Users.Remove(DeletedUser);
                userDbContext.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            using (var userDbContext = new PauDbContext())
            {
                return userDbContext.Users.ToList();
            }
        }

        public User GetUserById(int id)
        {
            using (var userDbContext = new PauDbContext())
            {
                return userDbContext.Users.Find(id);
            }
        }

        public User UpdateUser(User user)
        {
            using (var userDbContext = new PauDbContext())
            {
                userDbContext.Users.Update(user);
                userDbContext.SaveChanges();
                return user;
            }
        }
    }
}
