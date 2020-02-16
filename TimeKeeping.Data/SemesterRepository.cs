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
    public class SemesterRepository : DataManager, ISemesterRepository
    {
        public int Semester_Insert(SemesterModel sem)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var retValue = con.ExecuteScalar<int>("dbo.Usp_Semester_Insert",
                                new
                                {
                                    @iStrSemesterDesc = sem.SemesterDesc,
                                    @iStrSchoolYear = sem.SchoolYear,
                                    @iDtStartDate = sem.StartDate,
                                    @iDtEndDate = sem.EndDate,
                                    @iBitIsActive = sem.IsActive
                                }, commandType: CommandType.StoredProcedure);

                    return retValue;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SemesterModel Semester_SelectById(int id)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.QueryFirstOrDefault<SemesterModel>("dbo.Usp_Semester_SelectById",
                                  new { @iIntSemesterId = id },
                                  commandType: CommandType.StoredProcedure);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SemesterForDropdownModel> Semester_SelectForDropdown()
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<SemesterForDropdownModel>("dbo.Usp_Semester_SelectDropdown",
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

        public void Semester_Update(SemesterModel sem)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_Semester_Update",
                                new
                                {
                                    @iIntSemesterId = sem.SemesterId,
                                    @iStrSemesterDesc = sem.SemesterDesc,
                                    @iStrSchoolYear = sem.SchoolYear,
                                    @iDtStartDate = sem.StartDate,
                                    @iDtEndDate = sem.EndDate,
                                    @iBitIsActive = sem.IsActive
                                }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SemesterModel> Usp_Semester_Select(string strSearch)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<SemesterModel>("dbo.Usp_Semester_Select",
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
    }
}
