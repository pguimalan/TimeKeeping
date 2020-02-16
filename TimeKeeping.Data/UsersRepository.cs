using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class UsersRepository : DataManager, IUsersRepository
    {
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public int SystemUser_Insert(UserModel us)
        {
            CreatePasswordHash("12345678", out byte[] passwordHash, out byte[] passwordSalt);

            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.ExecuteScalar<int>("dbo.Usp_SystemUser_Insert",
                                new
                                {
                                    @iStrUserName = us.UserName,
                                    @iBinPasswordHash = passwordHash,
                                    @iBinPasswordSalt = passwordSalt,
                                    @iStrLastName = us.LastName,
                                    @iStrFirstName = us.FirstName,
                                    @iStrMiddleName = us.MiddleName
                                }, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SystemUser_ResetPassword(UserForResetPassword us)
        {
            CreatePasswordHash(us.strPassword, out byte[] passwordHash, out byte[] passwordSalt);
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_SystemUser_ResetPassword",
                                new
                                {
                                    @iIntUserId = us.UserId,
                                    @iBinPasswordHash = passwordHash,
                                    @iBinPasswordSalt = passwordSalt
                                }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UserModel SystemUser_SelectById(int userId)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.QueryFirstOrDefault<UserModel>("dbo.Usp_SystemUser_SelectById",
                                  new { @iIntUserId = userId },
                                  commandType: CommandType.StoredProcedure);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SystemUser_Update(UserModel us)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_SystemUser_Update",
                                new
                                {
                                    @iIntUserId = us.UserId,
                                    @iStrUserName = us.UserName,
                                    @iStrLastName = us.LastName,
                                    @iStrFirstName = us.FirstName,
                                    @iStrMiddleName = us.MiddleName
                                }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UserForSelect> SystemUser_Select(string strSearch)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<UserForSelect>("dbo.Usp_SystemUser_Select",
                                  new { @iStrSearch = strSearch },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Login(string username, string password)
        {
            using (var con = GetDbConnection())
            {
                var result = con.QueryFirstOrDefault<UserForAuthModel>("dbo.Usp_SystemUser_GetByUserName",
                              new
                              {
                                  @iStrUserName = username
                              },
                              commandType: CommandType.StoredProcedure);

                if (result == null)
                    return 0;

                bool IsOk = VerifyPasswordHash(password, result.PasswordHash, result.PasswordSalt);
                if (IsOk)
                    return result.UserId;
                else return 0;
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
