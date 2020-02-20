using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface IDtrService
    {
        int DTR_Log(int employeeId, DateTime timeLog, string strEvent);
        List<DTRLogModel> DTR_GenerateLog(string dateFrom, string dateTo, string deptName);
        List<IndividualDTR> DTR_IndividualTimeLog(int employeeId, int payrollId);
        DTRByIdModel DTR_GetById(int id);
        int DTR_ForceUpdate(DTRForceUpdateModel log);
    }
}
