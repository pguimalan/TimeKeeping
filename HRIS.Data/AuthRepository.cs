using Dapper;
using HRIS.Data.Interface;
using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data
{
    public class AuthRepository : DataManager, IAuthRepository
    {
        public bool Login(string username, string password)
        {
            using (var con = GetDbConnection())
            {
                var result = con.QueryFirstOrDefault<UserForAuthModel>("dbo.Usp_User_GetByUserName",
                              new
                              {
                                  @iStrUserName = username
                              },
                              commandType: CommandType.StoredProcedure);

                if (result == null)
                    return false;

                return VerifyPasswordHash(password, result.PasswordHash, result.PasswordSalt);
            }
        }

        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                        return false;
                }
                return true;
            }
        }
    }
}
