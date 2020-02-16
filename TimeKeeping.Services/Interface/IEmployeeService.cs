using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface IEmployeeService
    {
        int Employee_Insert(EmployeeForInsertModel em);
        List<EmployeeForSelectModel> Employee_Select(string strSearch);
        void Employee_Update(EmployeeForInsertModel em);
        EmployeeForInsertModel Employee_SelectById(int empId);
        EmployeeLeaveCreditsModel LeaveCredits_Select(int empId);
        int LeaveCredits_Update(int empId);
        EmployeeBasicInfo Employee_BasicInfo(int id);
    }
}
