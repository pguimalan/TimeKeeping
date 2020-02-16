using System.Collections.Generic;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface IUsersRepository
    {
        void SystemUser_Update(UserModel us);
        UserModel SystemUser_SelectById(int userId);
        void SystemUser_ResetPassword(UserForResetPassword us);
        int SystemUser_Insert(UserModel us);
        List<UserForSelect> SystemUser_Select(string strSearch);
        int Login(string username, string password);
    }
}
