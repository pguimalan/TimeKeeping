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

        public List<DTRLogModel> DTR_GenerateLog(string dateFrom, string dateTo, string deptName)
        {
            return _repo.DTR_GenerateLog(dateFrom, dateTo, deptName);
        }

        public int DTR_Log(int employeeId, DateTime timeLog, string strEvent)
        {
            return _repo.DTR_Log(employeeId, timeLog, strEvent);
        }
    }
}
