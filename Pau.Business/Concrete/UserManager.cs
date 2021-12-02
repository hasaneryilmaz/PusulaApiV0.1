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

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
            if(id > 0)
            {
                return _userRepository.GetUserById(id);
            }

            throw new Exception("Id 1 den küçük olamaz");
            
        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
