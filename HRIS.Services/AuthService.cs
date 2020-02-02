using HRIS.Data;
using HRIS.Data.Interface;
using HRIS.Services.Interface;

namespace HRIS.Services
{
    public class AuthService : IAuthService
    {
        static readonly IAuthRepository _repo = new AuthRepository();

        public bool Login(string username, string password)
        {
            return _repo.Login(username, password);
        }
    }
}
