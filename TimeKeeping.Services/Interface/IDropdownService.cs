using System.Collections.Generic;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface IDropdownService
    {
        List<EmployeeForDropdown> Employee_SelectDropdown();
        List<PayrollPeriodDropdown> PayrollPeriod_SelectDropdown();
    }
}
