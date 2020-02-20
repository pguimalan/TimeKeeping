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
    public class DtrRepository : DataManager, IDtrRepository
    {
        public int DTR_ForceUpdate(DTRForceUpdateModel log)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var retValue = con.ExecuteScalar<int>("dbo.Usp_DTR_ForceUpdate",
                                new
                                {
                                    @iIntLogId = log.LogId,
                                    @iIntEmployeeId = log.EmployeeId,
                                    @iDtCurrentDate = log.CurrentDate,
                                    @iTmTimeIn_AM = log.TimeIn_AM == TimeSpan.Zero ? null : log.TimeIn_AM,
                                    @iTmTimeOut_AM = log.TimeOut_AM == TimeSpan.Zero ? null : log.TimeOut_AM,                                    
                                    @iTmTimeIn_PM = log.TimeIn_PM == TimeSpan.Zero ? null : log.TimeIn_PM,                                    
                                    @iTmTimeOut_PM = log.TimeOut_PM == TimeSpan.Zero ? null : log.TimeOut_PM,
                                    @iTmTimeIn_Evening = log.TimeIn_Evening == TimeSpan.Zero ? null : log.TimeIn_Evening,                                    
                                    @iTmTimeOut_Evening = log.TimeOut_Evening == TimeSpan.Zero ? null : log.TimeOut_Evening,
                                }, commandType: CommandType.StoredProcedure);

                    return retValue;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DTRLogModel> DTR_GenerateLog(string dateFrom, string dateTo, string deptName)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<DTRLogModel>("dbo.Usp_DTR_GenerateLog",
                                  new 
                                  {
                                      @iDtFrom = dateFrom,
                                      @iDtTo = dateTo,
                                      @iStrDept = deptName
                                  },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DTRByIdModel DTR_GetById(int id)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.QueryFirstOrDefault<DTRByIdModel>("dbo.Usp_DTR_GetById",
                                  new
                                  {
                                      @iIntId = id
                                  },
                                  commandType: CommandType.StoredProcedure);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<IndividualDTR> DTR_IndividualTimeLog(int employeeId, int payrollId)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<IndividualDTR>("dbo.Usp_DTR_IndividualTimeLog",
                                  new
                                  {
                                      @iIntEmployeeId = employeeId,
                                      @iIntPayrollPeriod = payrollId
                                  },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int DTR_Log(int employeeId, DateTime timeLog, string strEvent)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var retValue = con.ExecuteScalar<int>("dbo.Usp_DTR_Log",
                                new
                                {
                                    @iIntEmployeeId = employeeId,
                                    @iDtTimelog = timeLog,
                                    @iStrEvent = strEvent
                                }, commandType: CommandType.StoredProcedure);

                    return retValue;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
