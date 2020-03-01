using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface IEmployeeLeaveService
    {
        List<EmployeeLeaveForListodel> EmployeeLeave_Select(int employeeId, DateTime dtFrom, DateTime dtTo);
        int EmployeeLeave_Insert(EmployeeLeaveForInsertodel lv);
        void EmployeeLeave_Update(EmployeeLeaveForInsertodel lv);
    }
}
