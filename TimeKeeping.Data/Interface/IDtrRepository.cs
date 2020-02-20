using System;
using System.Collections.Generic;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface IDtrRepository
    {
        int DTR_Log(int employeeId, DateTime timeLog, string strEvent);
        List<DTRLogModel> DTR_GenerateLog(string dateFrom, string dateTo, string deptName);
        List<IndividualDTR> DTR_IndividualTimeLog(int employeeId, int payrollId);
        DTRByIdModel DTR_GetById(int id);
        int DTR_ForceUpdate(DTRForceUpdateModel log);
    }
}
