using System;
using System.Collections.Generic;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class EmployeeLeaveService : IEmployeeLeaveService
    {
        static readonly IEmployeeLeaveRepository _repo = new EmployeeLeaveRepository();

        public int EmployeeLeave_Insert(EmployeeLeaveForInsertodel lv)
        {
            return _repo.EmployeeLeave_Insert(lv);
        }

        public List<EmployeeLeaveForListodel> EmployeeLeave_Select(int employeeId, DateTime dtFrom, DateTime dtTo)
        {
            return _repo.EmployeeLeave_Select(employeeId, dtFrom, dtTo);
        }

        public void EmployeeLeave_Update(EmployeeLeaveForInsertodel lv)
        {
            _repo.EmployeeLeave_Update(lv);
        }
    }
}
