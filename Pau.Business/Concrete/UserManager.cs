using Pau.Business.Abstract;
using Pau.DataAccess.Abstract;
using Pau.DataAccess.Concrete;
using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pau.Business.Concrete
{   public class UserManager : IUserService
    {


        private IUserRepository _userRepository;

        public UserManager()
        {
            _userRepository = new UserRepository();
        }


        public User CreateUser(User user)
        {
            return _userRepository.CreatUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers(); 
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
