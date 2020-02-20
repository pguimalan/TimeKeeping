using System;
using System.Collections.Generic;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class DtrService : IDtrService
    {
        static readonly IDtrRepository _repo = new DtrRepository();

        public int DTR_ForceUpdate(DTRForceUpdateModel log)
        {
            return _repo.DTR_ForceUpdate(log);
        }

        public List<DTRLogModel> DTR_GenerateLog(string dateFrom, string dateTo, string deptName)
        {
            return _repo.DTR_GenerateLog(dateFrom, dateTo, deptName);
        }

        public DTRByIdModel DTR_GetById(int id)
        {
            return _repo.DTR_GetById(id);
        }

        public List<IndividualDTR> DTR_IndividualTimeLog(int employeeId, int payrollId)
        {
            return _repo.DTR_IndividualTimeLog(employeeId, payrollId);
        }

        public int DTR_Log(int employeeId, DateTime timeLog, string strEvent)
        {
            return _repo.DTR_Log(employeeId, timeLog, strEvent);
        }
    }
}
