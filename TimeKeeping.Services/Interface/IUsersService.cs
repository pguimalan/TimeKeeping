using System.Collections.Generic;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface IUsersService
    {
        void SystemUser_Update(UserModel us);
        UserModel SystemUser_SelectById(int userId);
        void SystemUser_ResetPassword(UserForResetPassword us);
        int SystemUser_Insert(UserModel us);
        List<UserForSelect> SystemUser_Select(string strSearch);
        int Login(string username, string password);
    }
}
