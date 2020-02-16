using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface IDtrRepository
    {
        int DTR_Log(int employeeId, DateTime timeLog, string strEvent);
        List<DTRLogModel> DTR_GenerateLog(string dateFrom, string dateTo, string deptName);
    }
}
