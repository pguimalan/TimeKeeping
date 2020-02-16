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
