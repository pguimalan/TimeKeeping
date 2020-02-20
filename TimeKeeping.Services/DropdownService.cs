using System.Collections.Generic;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class DropdownService : IDropdownService
    {
        static readonly IDropdownRepository _repo = new DropdownRepository();

        public List<EmployeeForDropdown> Employee_SelectDropdown()
        {
            return _repo.Employee_SelectDropdown();
        }

        public List<PayrollPeriodDropdown> PayrollPeriod_SelectDropdown()
        {
            return _repo.PayrollPeriod_SelectDropdown();
        }
    }
}
