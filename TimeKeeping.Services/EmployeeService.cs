using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class EmployeeService : IEmployeeService
    {
        static readonly IEmployeeRepository _repo = new EmployeeRepository();

        public EmployeeBasicInfo Employee_BasicInfo(int id)
        {
            return _repo.Employee_BasicInfo(id);
        }

        public int Employee_Insert(EmployeeForInsertModel em)
        {
            return _repo.Employee_Insert(em);
        }

        public List<EmployeeForSelectModel> Employee_Select(string strSearch)
        {
            return _repo.Employee_Select(strSearch);
        }

        public EmployeeForInsertModel Employee_SelectById(int empId)
        {
            return _repo.Employee_SelectById(empId);
        }

        public void Employee_Update(EmployeeForInsertModel em)
        {
            _repo.Employee_Update(em);
        }

        public EmployeeLeaveCreditsModel LeaveCredits_Select(int empId)
        {
            return _repo.LeaveCredits_Select(empId);
        }

        public int LeaveCredits_Update(int empId)
        {
            return _repo.LeaveCredits_Update(empId);
        }
    }
}
