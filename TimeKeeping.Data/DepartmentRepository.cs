using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class DepartmentRepository : DataManager, IDepartmentRepository
    {
        public int Department_Insert(DepartmentModel ad)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var retValue = con.ExecuteScalar<int>("dbo.Usp_Department_Insert",
                                new
                                {
                                    @iStrDeptName = ad.DepartmentName
                                }, commandType: CommandType.StoredProcedure);

                    return retValue;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DepartmentModel> Department_Select(string search)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<DepartmentModel>("dbo.Usp_Department_Select",
                                  new { @iStrSearch = search },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DepartmentModel> Department_SelectForDTR()
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<DepartmentModel>("dbo.Usp_Department_SelectForDTR",
                                  null,
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Department_Update(DepartmentModel ad)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_Department_Update",
                                new
                                {
                                    @iIntDeptId = ad.DepartmentId,
                                    @iStrDeptName = ad.DepartmentName
                                }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
