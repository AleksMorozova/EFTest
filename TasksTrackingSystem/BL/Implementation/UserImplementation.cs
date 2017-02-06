using BL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace BL.Implementation
{
    public class UserImplementation : IUserContract
    {
        public List<User> GetAllUsers()
        {
            var allUser = Registration.UserRepository.ReadAll();

            return new List<User>();
        }

        public User GetUserByID()
        {
            var allUser = Registration.UserRepository.ReadAll();

            User createdUser = new User();

            createdUser.FirstName = allUser.FirstOrDefault().FirstName;
            createdUser.LastName = allUser.FirstOrDefault().LastName;
            createdUser.Login = allUser.FirstOrDefault().Login;

            return createdUser;
        }

        public void SaveUser(DomainModel.User user)
        {
            EFRepo.Model.UserDB createdUser = new EFRepo.Model.UserDB();

            createdUser.FirstName = user.FirstName;
            createdUser.LastName = user.LastName;
            createdUser.Login = user.Login;

            Registration.UserRepository.Create(createdUser);
        }
    }
}
