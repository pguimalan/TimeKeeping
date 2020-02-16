using System;
using System.Collections.Generic;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class UsersService : IUsersService
    {
        static readonly IUsersRepository _repo = new UsersRepository();

        public int Login(string username, string password)
        {
            return _repo.Login(username,password);
        }

        public int SystemUser_Insert(UserModel us)
        {
            return _repo.SystemUser_Insert(us);
        }

        public void SystemUser_ResetPassword(UserForResetPassword us)
        {
            _repo.SystemUser_ResetPassword(us);
        }

        public List<UserForSelect> SystemUser_Select(string strSearch)
        {
            return _repo.SystemUser_Select(strSearch);
        }

        public UserModel SystemUser_SelectById(int userId)
        {
            return _repo.SystemUser_SelectById(userId);
        }

        public void SystemUser_Update(UserModel us)
        {
            _repo.SystemUser_Update(us);
        }
    }
}
