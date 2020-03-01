using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface IEmployeeLeaveRepository
    {
        List<EmployeeLeaveForListodel> EmployeeLeave_Select(int employeeId, DateTime dtFrom, DateTime dtTo);
        int EmployeeLeave_Insert(EmployeeLeaveForInsertodel lv);
        void EmployeeLeave_Update(EmployeeLeaveForInsertodel lv);
    }
}
